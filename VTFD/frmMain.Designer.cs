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
            ((System.ComponentModel.ISupportInitialize)(this.crdLiveImage)).BeginInit();
            this.grpLiveImage.SuspendLayout();
            this.grpResultImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crdResultImage)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            this.tsbEditVpp});
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
            // 
            // tsbEditVpp
            // 
            this.tsbEditVpp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEditVpp.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditVpp.Image")));
            this.tsbEditVpp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditVpp.Name = "tsbEditVpp";
            this.tsbEditVpp.Size = new System.Drawing.Size(58, 22);
            this.tsbEditVpp.Text = "编辑vpp";
            // 
            // grpResultData
            // 
            this.grpResultData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpResultData.Location = new System.Drawing.Point(12, 364);
            this.grpResultData.Name = "grpResultData";
            this.grpResultData.Size = new System.Drawing.Size(653, 64);
            this.grpResultData.TabIndex = 6;
            this.grpResultData.TabStop = false;
            this.grpResultData.Text = "结果数据";
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
    }
}

