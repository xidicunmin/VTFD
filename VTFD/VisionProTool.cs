using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;

namespace VTFD
{

    class VisionProTool
    {
        #region 通用工具
        /// <summary>
        /// 加载CogToolBlock工具
        /// </summary>
        /// <param name="path"></param>
        /// <param name="errMsg"></param>
        /// <returns></returns>
        public static CogToolBlock LoadCogToolBlockTool(string path, ref string errMsg)
        {
            if (File.Exists(path))
            {
                try
                {
                    return (CogToolBlock)CogSerializer.LoadObjectFromFile(path,
                        new BinaryFormatter().GetType(), CogSerializationOptionsConstants.Minimum);
                }
                catch (Exception ex)
                {
                    errMsg = "加载VPP异常，异常信息：" + ex.Message;
                    return null;
                }
            }
            else
            {
                errMsg = "找不到VPP文件：" + path;
            }
            return null;
        }
        ///// <summary>
        ///// 加载棋盘格标定工具
        ///// </summary>
        ///// <param name="path">路径</param>
        ///// <param name="errMsg">错误信息</param>
        ///// <returns></returns>
        //public static CogCalibCheckerboardTool LoadCogCalibCheckerboardTool(string path, ref string errMsg)
        //{
        //    if (File.Exists(path))
        //    {
        //        try
        //        {
        //            return (CogCalibCheckerboardTool)CogSerializer.LoadObjectFromFile(path,
        //                new BinaryFormatter().GetType(), CogSerializationOptionsConstants.Minimum);
        //        }
        //        catch (Exception ex)
        //        {
        //            errMsg = "加载VPP异常，异常信息：" + ex.Message;
        //            return null;
        //        }
        //    }
        //    else
        //    {
        //        errMsg = "找不到VPP文件：" + path;
        //    }
        //    return null;
        //}
        ///// <summary>
        ///// 加载坐标系标定工具
        ///// </summary>
        ///// <param name="path">路径</param>
        ///// <param name="errMsg">错误信息</param>
        ///// <returns></returns>
        //public static CogCalibNPointToNPointTool LoadCogCalibNPointToNPointTool(string path, ref string errMsg)
        //{
        //    if (File.Exists(path))
        //    {
        //        try
        //        {
        //            return (CogCalibNPointToNPointTool)CogSerializer.LoadObjectFromFile(path,
        //                new BinaryFormatter().GetType(), CogSerializationOptionsConstants.Minimum);
        //        }
        //        catch (Exception ex)
        //        {
        //            errMsg = "加载VPP异常，异常信息：" + ex.Message;
        //            return null;
        //        }
        //    }
        //    else
        //    {
        //        errMsg = "找不到VPP文件：" + path;
        //    }
        //    return null;
        //}

        /// <summary>
        /// 加载相机Vpp
        /// </summary>
        /// <param name="path"></param>
        /// <param name="ErrMsg"></param>
        public static CogAcqFifoTool LoadVppAcq(string path, ref string ErrMsg)
        {
            if (File.Exists(path))
            {
                try
                {
                    CogAcqFifoTool camera = (CogAcqFifoTool)CogSerializer.LoadObjectFromFile(path);
                    camera.Operator.TimeoutEnabled = false;
                    camera.Operator.OwnedTriggerParams.TriggerEnabled = true;
                    camera.Operator.OwnedTriggerParams.TriggerModel = CogAcqTriggerModelConstants.Manual;
                    return camera;
                }
                catch (Exception ex)
                {
                    ErrMsg = "加载VPP异常，异常信息：" + ex.Message;
                    return null;
                }
            }
            else
            {
                ErrMsg = "找不到VPP文件：" + path;
            }
            return null;
        }


        public static bool SaveVppAcq(CogAcqFifoTool acqTool, string path)
        {
            try
            {
                CogSerializer.SaveObjectToFile(acqTool, path, typeof(BinaryFormatter), CogSerializationOptionsConstants.Minimum);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool SaveVpp(object tool, string path)
        {
            try
            {
                CogSerializer.SaveObjectToFile(tool, path, typeof(BinaryFormatter), CogSerializationOptionsConstants.Minimum);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 从相机中获取图像
        /// </summary>
        /// <param name="camera"></param>
        /// <param name="errMsg"></param>
        /// <returns></returns>
        public static CogImage8Grey GetImage(CogAcqFifoTool camera, ref string errMsg)
        {
            if (camera != null)
            {
                CogImage8Grey image = null;
                try
                {
                    camera.Run();
                    if (camera.RunStatus.Result == CogToolResultConstants.Accept)
                    {
                        image = (CogImage8Grey)camera.OutputImage;
                    }
                    else
                    {
                        image = null;
                    }
                    //偶尔会有取像异常，需要二次取像
                    if (image == null)
                    {
                        camera.Run();
                        if (camera.RunStatus.Result == CogToolResultConstants.Accept)
                        {
                            image = (CogImage8Grey)camera.OutputImage;
                        }
                        else
                        {
                            errMsg = "相机二次取像都失败，无法获取图片";
                        }
                    }
                }
                catch (Exception ex)
                {
                    image = null;
                    errMsg = "相机取像出现异常，异常信息：" + ex.Message;
                }
                return image;
            }
            else
            {
                errMsg = "相机尚未初始化";
            }
            return null;
        }
        /// <summary>
        /// 复制一个Cognex工具
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static object CopyTool(object obj)
        {
            return CogSerializer.DeepCopyObject(obj);
        }
        #endregion
    }
}
