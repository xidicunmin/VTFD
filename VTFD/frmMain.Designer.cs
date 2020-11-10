namespace VTFD
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.crdLiveImage = new Cognex.VisionPro.CogRecordDisplay();
            this.grpLiveImage = new System.Windows.Forms.GroupBox();
            this.grpResultImage = new System.Windows.Forms.GroupBox();
            this.crdResultImage = new Cognex.VisionPro.CogRecordDisplay();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCameraStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbStart = new System.Windows.Forms.ToolStripButton();
            this.tsbStop = new System.Windows.Forms.ToolStripButton();
            this.tsbEditCamera = new System.Windows.Forms.ToolStripButton();
            this.tsbEditVpp = new System.Windows.Forms.ToolStripButton();
            this.grpResultData = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRunStatus = new System.Windows.Forms.Label();
            this.lblWidth1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWidth2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tsbSaveImage = new System.Windows.Forms.ToolStripButton();
            this.tsbOpenImagePath = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.crdLiveImage)).BeginInit();
            this.grpLiveImage.SuspendLayout();
            this.grpResultImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crdResultImage)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.grpResultData.SuspendLayout();
            this.SuspendLayout();
            // 
            // crdLiveImage
            // 
            this.crdLiveImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crdLiveImage.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.crdLiveImage.ColorMapLowerRoiLimit = 0D;
            this.crdLiveImage.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.crdLiveImage.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.crdLiveImage.ColorMapUpperRoiLimit = 1D;
            this.crdLiveImage.DoubleTapZoomCycleLength = 2;
            this.crdLiveImage.DoubleTapZoomSensitivity = 2.5D;
            this.crdLiveImage.Location = new System.Drawing.Point(6, 20);
            this.crdLiveImage.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.crdLiveImage.MouseWheelSensitivity = 1D;
            this.crdLiveImage.Name = "crdLiveImage";
            this.crdLiveImage.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("crdLiveImage.OcxState")));
            this.crdLiveImage.Size = new System.Drawing.Size(308, 324);
            this.crdLiveImage.TabIndex = 0;
            // 
            // grpLiveImage
            // 
            this.grpLiveImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLiveImage.Controls.Add(this.crdLiveImage);
            this.grpLiveImage.Location = new System.Drawing.Point(3, 3);
            this.grpLiveImage.Name = "grpLiveImage";
            this.grpLiveImage.Size = new System.Drawing.Size(320, 326);
            this.grpLiveImage.TabIndex = 1;
            this.grpLiveImage.TabStop = false;
            this.grpLiveImage.Text = "实时图像";
            // 
            // grpResultImage
            // 
            this.grpResultImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpResultImage.Controls.Add(this.crdResultImage);
            this.grpResultImage.Location = new System.Drawing.Point(329, 3);
            this.grpResultImage.Name = "grpResultImage";
            this.grpResultImage.Size = new System.Drawing.Size(321, 326);
            this.grpResultImage.TabIndex = 2;
            this.grpResultImage.TabStop = false;
            this.grpResultImage.Text = "结果图像";
            // 
            // crdResultImage
            // 
            this.crdResultImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crdResultImage.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.crdResultImage.ColorMapLowerRoiLimit = 0D;
            this.crdResultImage.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.crdResultImage.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.crdResultImage.ColorMapUpperRoiLimit = 1D;
            this.crdResultImage.DoubleTapZoomCycleLength = 2;
            this.crdResultImage.DoubleTapZoomSensitivity = 2.5D;
            this.crdResultImage.Location = new System.Drawing.Point(6, 20);
            this.crdResultImage.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.crdResultImage.MouseWheelSensitivity = 1D;
            this.crdResultImage.Name = "crdResultImage";
            this.crdResultImage.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("crdResultImage.OcxState")));
            this.crdResultImage.Size = new System.Drawing.Size(309, 324);
            this.crdResultImage.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.grpResultImage, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpLiveImage, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.13669F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(653, 332);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslCameraStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(677, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel1.Text = "相机状态：";
            // 
            // tsslCameraStatus
            // 
            this.tsslCameraStatus.Name = "tsslCameraStatus";
            this.tsslCameraStatus.Size = new System.Drawing.Size(32, 17);
            this.tsslCameraStatus.Text = "断开";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbStart,
            this.tsbStop,
            this.tsbEditCamera,
            this.tsbEditVpp,
            this.tsbSaveImage,
            this.tsbOpenImagePath});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(677, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbStart
            // 
            this.tsbStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbStart.Image = ((System.Drawing.Image)(resources.GetObject("tsbStart.Image")));
            this.tsbStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStart.Name = "tsbStart";
            this.tsbStart.Size = new System.Drawing.Size(60, 22);
            this.tsbStart.Text = "开始运行";
            this.tsbStart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbStart.Click += new System.EventHandler(this.tsbStart_Click);
            // 
            // tsbStop
            // 
            this.tsbStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbStop.Image = ((System.Drawing.Image)(resources.GetObject("tsbStop.Image")));
            this.tsbStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStop.Name = "tsbStop";
            this.tsbStop.Size = new System.Drawing.Size(60, 22);
            this.tsbStop.Text = "停止运行";
            this.tsbStop.Click += new System.EventHandler(this.tsbStart_Click);
            // 
            // tsbEditCamera
            // 
            this.tsbEditCamera.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEditCamera.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditCamera.Image")));
            this.tsbEditCamera.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditCamera.Name = "tsbEditCamera";
            this.tsbEditCamera.Size = new System.Drawing.Size(60, 22);
            this.tsbEditCamera.Text = "编辑相机";
            this.tsbEditCamera.Click += new System.EventHandler(this.tsbEditCamera_Click);
            // 
            // tsbEditVpp
            // 
            this.tsbEditVpp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEditVpp.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditVpp.Image")));
            this.tsbEditVpp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditVpp.Name = "tsbEditVpp";
            this.tsbEditVpp.Size = new System.Drawing.Size(58, 22);
            this.tsbEditVpp.Text = "编辑vpp";
            this.tsbEditVpp.Click += new System.EventHandler(this.tsbEditVpp_Click);
            // 
            // grpResultData
            // 
            this.grpResultData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpResultData.Controls.Add(this.lblWidth2);
            this.grpResultData.Controls.Add(this.label6);
            this.grpResultData.Controls.Add(this.lblWidth1);
            this.grpResultData.Controls.Add(this.label4);
            this.grpResultData.Controls.Add(this.lblRunStatus);
            this.grpResultData.Controls.Add(this.label1);
            this.grpResultData.Location = new System.Drawing.Point(12, 364);
            this.grpResultData.Name = "grpResultData";
            this.grpResultData.Size = new System.Drawing.Size(653, 64);
            this.grpResultData.TabIndex = 6;
            this.grpResultData.TabStop = false;
            this.grpResultData.Text = "结果数据";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "结果:";
            // 
            // lblRunStatus
            // 
            this.lblRunStatus.AutoSize = true;
            this.lblRunStatus.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRunStatus.Location = new System.Drawing.Point(73, 28);
            this.lblRunStatus.Name = "lblRunStatus";
            this.lblRunStatus.Size = new System.Drawing.Size(24, 16);
            this.lblRunStatus.TabIndex = 1;
            this.lblRunStatus.Text = "OK";
            // 
            // lblWidth1
            // 
            this.lblWidth1.AutoSize = true;
            this.lblWidth1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWidth1.Location = new System.Drawing.Point(207, 28);
            this.lblWidth1.Name = "lblWidth1";
            this.lblWidth1.Size = new System.Drawing.Size(16, 16);
            this.lblWidth1.TabIndex = 3;
            this.lblWidth1.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(145, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "宽度1:";
            // 
            // lblWidth2
            // 
            this.lblWidth2.AutoSize = true;
            this.lblWidth2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWidth2.Location = new System.Drawing.Point(347, 28);
            this.lblWidth2.Name = "lblWidth2";
            this.lblWidth2.Size = new System.Drawing.Size(16, 16);
            this.lblWidth2.TabIndex = 5;
            this.lblWidth2.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(285, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "宽度2:";
            // 
            // tsbSaveImage
            // 
            this.tsbSaveImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSaveImage.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveImage.Image")));
            this.tsbSaveImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveImage.Name = "tsbSaveImage";
            this.tsbSaveImage.Size = new System.Drawing.Size(84, 22);
            this.tsbSaveImage.Text = "关闭保存图片";
            this.tsbSaveImage.Click += new System.EventHandler(this.tsbSaveImage_Click);
            // 
            // tsbOpenImagePath
            // 
            this.tsbOpenImagePath.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbOpenImagePath.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpenImagePath.Image")));
            this.tsbOpenImagePath.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenImagePath.Name = "tsbOpenImagePath";
            this.tsbOpenImagePath.Size = new System.Drawing.Size(96, 22);
            this.tsbOpenImagePath.Text = "打开图片文件夹";
            this.tsbOpenImagePath.Click += new System.EventHandler(this.tsbOpenImagePath_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.grpResultData);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmMain";
            this.Text = "ViDi测试";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crdLiveImage)).EndInit();
            this.grpLiveImage.ResumeLayout(false);
            this.grpResultImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.crdResultImage)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpResultData.ResumeLayout(false);
            this.grpResultData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Cognex.VisionPro.CogRecordDisplay crdLiveImage;
        private System.Windows.Forms.GroupBox grpLiveImage;
        private System.Windows.Forms.GroupBox grpResultImage;
        private Cognex.VisionPro.CogRecordDisplay crdResultImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslCameraStatus;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbStart;
        private System.Windows.Forms.ToolStripButton tsbStop;
        private System.Windows.Forms.GroupBox grpResultData;
        private System.Windows.Forms.ToolStripButton tsbEditCamera;
        private System.Windows.Forms.ToolStripButton tsbEditVpp;
        private System.Windows.Forms.Label lblWidth2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblWidth1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRunStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton tsbSaveImage;
        private System.Windows.Forms.ToolStripButton tsbOpenImagePath;
    }
}

