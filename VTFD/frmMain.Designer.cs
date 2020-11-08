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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.grpResultData = new System.Windows.Forms.GroupBox();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
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
            this.crdLiveImage.Size = new System.Drawing.Size(293, 290);
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
            this.grpLiveImage.Size = new System.Drawing.Size(305, 316);
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
            this.grpResultImage.Location = new System.Drawing.Point(314, 3);
            this.grpResultImage.Name = "grpResultImage";
            this.grpResultImage.Size = new System.Drawing.Size(306, 316);
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
            this.crdResultImage.Size = new System.Drawing.Size(294, 290);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.13669F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(623, 322);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslCameraStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(647, 22);
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
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(647, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton1.Text = "开始运行";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton2.Text = "停止运行";
            // 
            // grpResultData
            // 
            this.grpResultData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpResultData.Location = new System.Drawing.Point(12, 356);
            this.grpResultData.Name = "grpResultData";
            this.grpResultData.Size = new System.Drawing.Size(623, 69);
            this.grpResultData.TabIndex = 6;
            this.grpResultData.TabStop = false;
            this.grpResultData.Text = "结果数据";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton3.Text = "编辑相机";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(58, 22);
            this.toolStripButton4.Text = "编辑vpp";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.grpResultData);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmMain";
            this.Text = "ViDi测试";
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
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.GroupBox grpResultData;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}

