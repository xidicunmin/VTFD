using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;
using Cognex.VisionPro.CalibFix;
using Cognex.VisionPro.ImageFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace VTFD
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public static CameraCL.CognexAreaCamera cognexAreaCamera = new CameraCL.CognexAreaCamera();

        bool runStart;

        bool processEndStatus;

        static Thread processThread;

        static VisionResult visionResult;

        public static CogToolBlock processToolBlock;

        static CogAcqFifoTool acqFifoTool;

        static bool isSaveImage;

        static int recurCount;

        static double lastCoordX;

        string imageSavePath;

        bool cameraStatus;

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                string loadMsg = string.Empty;
               

                string saveImage = GetValue("SaveImage");
                if(saveImage == "")
                {
                    saveImage = "true";
                    SetValue("SaveImage", saveImage);
                }
                isSaveImage = !bool.Parse(saveImage);
                tsbSaveImage_Click(null, null);

                imageSavePath = GetValue("SaveImagePath");
                if(imageSavePath == "")
                {
                    imageSavePath = Application.StartupPath + "\\图片";
                    SetValue("SaveImagePath", imageSavePath);
                }

                //订阅事件
                cognexAreaCamera.CameraStatusChange += CognexAreaCamera_CameraStatusChange;

                //载入相机
                string cameraPath = GetValue("CameraVppPath");
                if (cameraPath == "")
                {
                    cameraPath = Application.StartupPath + "\\Vpp\\acq.vpp";
                    SetValue("CameraVppPath", cameraPath);
                }
                //cognexAreaCamera.LoadCamera(1, cameraPath,out cameraLoadStatus,out loadMsg);
                acqFifoTool = (CogAcqFifoTool)CogSerializer.LoadObjectFromFile(cameraPath,
                        new BinaryFormatter().GetType(), CogSerializationOptionsConstants.Minimum);
                if (acqFifoTool.Operator != null)
                {
                    crdLiveImage.StartLiveDisplay(acqFifoTool.Operator);
                    //runStart = true;
                    CognexAreaCamera_CameraStatusChange(1, true);
                    processEndStatus = true;
                }

                //if (cameraLoadStatus)
                //{
                //    crdLiveImage.StartLiveDisplay(cognexAreaCamera.AcqFifo);
                //    //runStart = true;
                //    processEndStatus = true;
                //}

                //载入Vpp
                string processVppPath = GetValue("ProcessVppPath");
                if (processVppPath == "")
                {
                    processVppPath = Application.StartupPath + "\\Vpp\\test.vpp";
                    SetValue("ProcessVppPath", processVppPath);
                }
                processToolBlock = (CogToolBlock)CogSerializer.LoadObjectFromFile(processVppPath,
                        new BinaryFormatter().GetType(), CogSerializationOptionsConstants.Minimum);

                if (processToolBlock != null)
                {
                    processThread = new Thread(ThreadProcess);
                    processThread.Priority = ThreadPriority.AboveNormal;
                    processThread.IsBackground = true;
                    processThread.Start();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("初始化软件异常：" + ex);
                Close();
            }
        }

        private void ThreadProcess()
        {
            while (true)
            {
                if (runStart && processEndStatus)
                {
                    processEndStatus = false;
                    try
                    {

                        visionResult = new VisionResult();
                        visionResult.StartTime = DateTime.Now;

                        //程序运行
                        acqFifoTool.Run();

                        if (acqFifoTool.OutputImage != null)
                        {
                            

                            visionResult.InputImage = acqFifoTool.OutputImage;

                            processToolBlock.Inputs[0].Value = visionResult.InputImage;
                            processToolBlock.Run();

                            if (processToolBlock.RunStatus.Result == CogToolResultConstants.Accept)
                            {
                                CogCalibCheckerboardTool checkerboardTool = (CogCalibCheckerboardTool)processToolBlock.Tools[0];
                                visionResult.OutputImage = checkerboardTool.OutputImage;
                                visionResult.cogRecord = processToolBlock.CreateLastRunRecord();
                                visionResult.width1 = (double)processToolBlock.Outputs[0].Value;
                                visionResult.width2 = (double)processToolBlock.Outputs[1].Value;
                                visionResult.CoordX = (double)processToolBlock.Outputs[4].Value;
                                visionResult.RunStatus = true;
                                visionResult.RunStatusText = "OK";


                                //判断是否重复
                                if (Math.Abs(visionResult.CoordX - lastCoordX) < 0.05)
                                {
                                    recurCount++;
                                    if (recurCount > 9)
                                    {
                                        toolStrip1.Invoke(new Action(delegate
                                        {
                                            tsbStart_Click(null, null);
                                            MessageBox.Show(string.Format("检测到产品未移动，次数{0}，自动停止运行，请适当挪动产品", recurCount));
                                        }));
                                    }
                                }
                                else
                                {
                                    recurCount = 0;
                                }
                                lastCoordX = visionResult.CoordX;


                                //判断处理
                                visionResult.ExamineStatus = true;
                            }
                            else
                            {
                                visionResult.OutputImage = visionResult.InputImage;
                                visionResult.cogRecord = null;
                                visionResult.RunStatusText = "未识别";
                                visionResult.RunStatus = false;
                                visionResult.width1 = 999;
                                visionResult.width2 = 999;
                                visionResult.CoordX = 0;
                            }

                           

                            //保存原图图片
                            if (isSaveImage && visionResult.RunStatus)
                            {
                                visionResult.ImagePath = string.Format("{0}\\{2}\\{1}", imageSavePath, visionResult.ExamineStatus ? "OK" : "NG", visionResult.StartTime.ToString("yyMMdd"));
                                if (!Directory.Exists(visionResult.ImagePath))
                                {
                                    Directory.CreateDirectory(visionResult.ImagePath);
                                }
                                CogImageFile cogImageFile = new CogImageFile();
                                cogImageFile.Open(visionResult.ImagePath + "\\" + visionResult.StartTime.ToString("HHmmssfff") + ".bmp", CogImageFileModeConstants.Write);
                                cogImageFile.Append(visionResult.InputImage);
                                cogImageFile.Close();
                            }

                            crdResultImage.Invoke(new Action(delegate
                            {
                                crdResultImage.InteractiveGraphics.Clear();
                                crdResultImage.StaticGraphics.Clear();
                                crdResultImage.Image = null;
                                crdResultImage.Image = visionResult.OutputImage;
                                crdResultImage.Record = visionResult.cogRecord;
                                lblRunStatus.Text = visionResult.RunStatusText;
                                lblRunStatus.ForeColor = visionResult.RunStatus ? Color.Green : Color.Red;
                                lblWidth1.Text = visionResult.width1.ToString("0.000");
                                lblWidth2.Text = visionResult.width2.ToString("0.000");

                                //保存画线图
                                if (isSaveImage && visionResult.RunStatus && !visionResult.ExamineStatus)
                                {
                                    Bitmap crdImage = (Bitmap)crdResultImage.CreateContentBitmap(Cognex.VisionPro.Display.CogDisplayContentBitmapConstants.Image);
                                    crdImage.Save(visionResult.ImagePath + "\\crd_" + visionResult.StartTime.ToString("HHmmssfff") + ".jpeg", ImageFormat.Jpeg);
                                }
                            }));
                        }
                        else
                        {
                            CognexAreaCamera_CameraStatusChange(1, false);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("图片处理异常：" + ex);
                        tsbStart_Click(null, null);
                    }
                    processEndStatus = true;
                }
                if (!cameraStatus)
                {
                    acqFifoTool.Run();
                    if(acqFifoTool.RunStatus.Result == CogToolResultConstants.Accept)
                    {
                        CognexAreaCamera_CameraStatusChange(1, true);
                    }
                }

                Thread.Sleep(1);
            }
        }

        private void CognexAreaCamera_CameraStatusChange(int cameraId, bool status)
        {
            //if (InvokeRequired)
            //{

            //    BeginInvoke(new CameraCL.CognexAreaCamera.OnCameraStatusChange(CognexAreaCamera_CameraStatusChange), cameraId, status);
            //    return;
            //}
            cameraStatus = status;
            statusStrip1.Invoke(new Action(delegate {
                tsslCameraStatus.Text = status ? "连接" : "断开";
                tsbStart_Click(null, null);
            }));
            
        }

        /// <summary>  
        /// 写入值  
        /// </summary>  
        /// <param name="key"></param>  
        /// <param name="value"></param>  
        public static void SetValue(string key, string value)
        {
            //增加的内容写在appSettings段下 <add key="RegCode" value="0"/>  
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (config.AppSettings.Settings[key] == null)
            {
                config.AppSettings.Settings.Add(key, value);
            }
            else
            {
                config.AppSettings.Settings[key].Value = value;
            }
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");//重新加载新的配置文件   
        }

        /// <summary>  
        /// 读取指定key的值  
        /// </summary>  
        /// <param name="key"></param>  
        /// <returns></returns>  
        public static string GetValue(string key)
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (config.AppSettings.Settings[key] == null)
                return "";
            else
                return config.AppSettings.Settings[key].Value;
        }

        private void tsbStart_Click(object sender, EventArgs e)
        {
            if(tsslCameraStatus.Text == "连接")
            {
                if (runStart)
                {
                    runStart = false;
                    tsbStop.Enabled = false;
                    tsbStart.Enabled = tsbEditCamera.Enabled = tsbEditVpp.Enabled = true;

                }
                else
                {
                    runStart = true;
                    tsbStop.Enabled = true;
                    tsbStart.Enabled = tsbEditCamera.Enabled = tsbEditVpp.Enabled = false;
                }
            }
            else
            {
                runStart = false;
                tsbStart.Enabled = true;
                tsbStop.Enabled = false;
                MessageBox.Show("相机未连接，无法启动");
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            crdLiveImage.StopLiveDisplay();
            var frameGrabbers = new CogFrameGrabbers();
            foreach (ICogFrameGrabber fg in frameGrabbers)
            {
                fg.Disconnect(false);
            }
            Thread.Sleep(100);
            Process.GetCurrentProcess().Kill();
            Thread.Sleep(100);
            Environment.Exit(0);
        }

        private void tsbEditCamera_Click(object sender, EventArgs e)
        {
            Vision.FrmCameraEdit frmCameraEdit = new Vision.FrmCameraEdit();
            bool save;
            CogAcqFifoTool backTool = (CogAcqFifoTool)VisionProTool.CopyTool(acqFifoTool);
            CogAcqFifoTool tool = frmCameraEdit.ShowEdit(backTool, "相机编辑", out save);
            if (save)
            {
                acqFifoTool = tool;
            }
            CogSerializer.SaveObjectToFile(acqFifoTool, GetValue("CameraVppPath"));
        }

        private void tsbEditVpp_Click(object sender, EventArgs e)
        {
            Vision.FrmToolBlock frmToolBlock = new Vision.FrmToolBlock();
            frmToolBlock.ToolBlockSave += FrmToolBlock_ToolBlockSave;
            CogToolBlock backTool = (CogToolBlock)VisionProTool.CopyTool(processToolBlock);
            frmToolBlock.ShowEdit(null, null, false, false, backTool, backTool, 1, "vpp编辑");
        }

        private void FrmToolBlock_ToolBlockSave(int toolBlockId, CogToolBlock editTool, CogToolBlock backupTool, bool save)
        {
            if (save)
            {
                processToolBlock = editTool;
                CogSerializer.SaveObjectToFile(processToolBlock, GetValue("ProcessVppPath"));
            }
        }

        private void tsbSaveImage_Click(object sender, EventArgs e)
        {
            isSaveImage = !isSaveImage;
            tsbSaveImage.Text = isSaveImage ? "关闭保存图片" : "打开保存图片";
            SetValue("SaveImage", isSaveImage.ToString());
        }

        private void tsbOpenImagePath_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", imageSavePath);
        }
    }
}
