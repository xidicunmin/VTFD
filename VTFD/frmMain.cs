using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;

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

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                string loadMsg = string.Empty;
                bool cameraLoadStatus;

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

            }
        }

        private void ThreadProcess()
        {
            while (true)
            {
                if (runStart && processEndStatus)
                {
                    processEndStatus = false;
                    //程序运行
                    acqFifoTool.Run();

                    if (acqFifoTool.OutputImage!=null)
                    {
                        visionResult = new VisionResult();

                        visionResult.InputImage = acqFifoTool.OutputImage;

                        processToolBlock.Inputs[0].Value = visionResult.InputImage;
                        processToolBlock.Run();

                        if(processToolBlock.RunStatus.Result == CogToolResultConstants.Accept)
                        {
                            visionResult.OutputImage = (ICogImage)processToolBlock.Outputs[3].Value;
                            visionResult.cogRecord = processToolBlock.CreateLastRunRecord();
                        }
                        else
                        {
                            visionResult.OutputImage = visionResult.InputImage;
                            visionResult.cogRecord = null;
                        }

                        crdResultImage.Invoke(new Action(delegate
                        {
                            crdResultImage.InteractiveGraphics.Clear();
                            crdResultImage.StaticGraphics.Clear();
                            crdResultImage.Image = null;
                            crdResultImage.Image = visionResult.OutputImage;
                            crdResultImage.Record = visionResult.cogRecord;
                        }));
                    }
                    else
                    {
                        CognexAreaCamera_CameraStatusChange(1, false);
                    }

                    processEndStatus = true;
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
                    tsbStart.Enabled = true;
                }
                else
                {
                    runStart = true;
                    tsbStop.Enabled = true;
                    tsbStart.Enabled = false;
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
            
        }
    }
}
