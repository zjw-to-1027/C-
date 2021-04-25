using System.IO.Ports;

namespace FrameTwo
{
    partial class FrmMain
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconBtnSetUp = new FontAwesome.Sharp.IconButton();
            this.iconBtnAdditionalTool = new FontAwesome.Sharp.IconButton();
            this.iconBtnPumpTest = new FontAwesome.Sharp.IconButton();
            this.iconBtnExperimentalTest = new FontAwesome.Sharp.IconButton();
            this.iconBtnDataProcessing = new FontAwesome.Sharp.IconButton();
            this.iconBtnSample = new FontAwesome.Sharp.IconButton();
            this.iconBtnCalibration = new FontAwesome.Sharp.IconButton();
            this.iconBtnConfigure = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labTime = new System.Windows.Forms.Label();
            this.labTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.dateTime = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(171)))), ((int)(((byte)(230)))));
            this.panelMenu.Controls.Add(this.iconBtnSetUp);
            this.panelMenu.Controls.Add(this.iconBtnAdditionalTool);
            this.panelMenu.Controls.Add(this.iconBtnPumpTest);
            this.panelMenu.Controls.Add(this.iconBtnExperimentalTest);
            this.panelMenu.Controls.Add(this.iconBtnDataProcessing);
            this.panelMenu.Controls.Add(this.iconBtnSample);
            this.panelMenu.Controls.Add(this.iconBtnCalibration);
            this.panelMenu.Controls.Add(this.iconBtnConfigure);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(175, 631);
            this.panelMenu.TabIndex = 0;
            // 
            // iconBtnSetUp
            // 
            this.iconBtnSetUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(171)))), ((int)(((byte)(230)))));
            this.iconBtnSetUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnSetUp.FlatAppearance.BorderSize = 0;
            this.iconBtnSetUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnSetUp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iconBtnSetUp.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnSetUp.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.iconBtnSetUp.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnSetUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnSetUp.IconSize = 32;
            this.iconBtnSetUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnSetUp.Location = new System.Drawing.Point(0, 542);
            this.iconBtnSetUp.Name = "iconBtnSetUp";
            this.iconBtnSetUp.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconBtnSetUp.Size = new System.Drawing.Size(175, 60);
            this.iconBtnSetUp.TabIndex = 11;
            this.iconBtnSetUp.Text = "设置";
            this.iconBtnSetUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnSetUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnSetUp.UseVisualStyleBackColor = false;
            this.iconBtnSetUp.Click += new System.EventHandler(this.iconBtnSetUp_Click_1);
            // 
            // iconBtnAdditionalTool
            // 
            this.iconBtnAdditionalTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(171)))), ((int)(((byte)(230)))));
            this.iconBtnAdditionalTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnAdditionalTool.FlatAppearance.BorderSize = 0;
            this.iconBtnAdditionalTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnAdditionalTool.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iconBtnAdditionalTool.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnAdditionalTool.IconChar = FontAwesome.Sharp.IconChar.DraftingCompass;
            this.iconBtnAdditionalTool.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnAdditionalTool.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnAdditionalTool.IconSize = 32;
            this.iconBtnAdditionalTool.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnAdditionalTool.Location = new System.Drawing.Point(0, 482);
            this.iconBtnAdditionalTool.Name = "iconBtnAdditionalTool";
            this.iconBtnAdditionalTool.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconBtnAdditionalTool.Size = new System.Drawing.Size(175, 60);
            this.iconBtnAdditionalTool.TabIndex = 10;
            this.iconBtnAdditionalTool.Text = "附加工具";
            this.iconBtnAdditionalTool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnAdditionalTool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnAdditionalTool.UseVisualStyleBackColor = false;
            this.iconBtnAdditionalTool.Click += new System.EventHandler(this.iconBtnAdditionalTool_Click_1);
            // 
            // iconBtnPumpTest
            // 
            this.iconBtnPumpTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(171)))), ((int)(((byte)(230)))));
            this.iconBtnPumpTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnPumpTest.FlatAppearance.BorderSize = 0;
            this.iconBtnPumpTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnPumpTest.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iconBtnPumpTest.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnPumpTest.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.iconBtnPumpTest.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnPumpTest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnPumpTest.IconSize = 32;
            this.iconBtnPumpTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnPumpTest.Location = new System.Drawing.Point(0, 422);
            this.iconBtnPumpTest.Name = "iconBtnPumpTest";
            this.iconBtnPumpTest.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconBtnPumpTest.Size = new System.Drawing.Size(175, 60);
            this.iconBtnPumpTest.TabIndex = 9;
            this.iconBtnPumpTest.Text = "注射泵测试";
            this.iconBtnPumpTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnPumpTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnPumpTest.UseVisualStyleBackColor = false;
            this.iconBtnPumpTest.Click += new System.EventHandler(this.iconBtnPumpTest_Click_1);
            // 
            // iconBtnExperimentalTest
            // 
            this.iconBtnExperimentalTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(171)))), ((int)(((byte)(230)))));
            this.iconBtnExperimentalTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnExperimentalTest.FlatAppearance.BorderSize = 0;
            this.iconBtnExperimentalTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnExperimentalTest.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnExperimentalTest.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.iconBtnExperimentalTest.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnExperimentalTest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnExperimentalTest.IconSize = 32;
            this.iconBtnExperimentalTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnExperimentalTest.Location = new System.Drawing.Point(0, 362);
            this.iconBtnExperimentalTest.Name = "iconBtnExperimentalTest";
            this.iconBtnExperimentalTest.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconBtnExperimentalTest.Size = new System.Drawing.Size(175, 60);
            this.iconBtnExperimentalTest.TabIndex = 8;
            this.iconBtnExperimentalTest.Text = "实验测试";
            this.iconBtnExperimentalTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnExperimentalTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnExperimentalTest.UseVisualStyleBackColor = false;
            this.iconBtnExperimentalTest.Click += new System.EventHandler(this.iconBtnExperimentalTest_Click);
            // 
            // iconBtnDataProcessing
            // 
            this.iconBtnDataProcessing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(171)))), ((int)(((byte)(230)))));
            this.iconBtnDataProcessing.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnDataProcessing.FlatAppearance.BorderSize = 0;
            this.iconBtnDataProcessing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnDataProcessing.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnDataProcessing.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.iconBtnDataProcessing.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnDataProcessing.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnDataProcessing.IconSize = 32;
            this.iconBtnDataProcessing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnDataProcessing.Location = new System.Drawing.Point(0, 302);
            this.iconBtnDataProcessing.Name = "iconBtnDataProcessing";
            this.iconBtnDataProcessing.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconBtnDataProcessing.Size = new System.Drawing.Size(175, 60);
            this.iconBtnDataProcessing.TabIndex = 4;
            this.iconBtnDataProcessing.Text = "数据处理";
            this.iconBtnDataProcessing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnDataProcessing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnDataProcessing.UseVisualStyleBackColor = false;
            this.iconBtnDataProcessing.Click += new System.EventHandler(this.iconBtnDataProcessing_Click);
            // 
            // iconBtnSample
            // 
            this.iconBtnSample.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(171)))), ((int)(((byte)(230)))));
            this.iconBtnSample.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnSample.FlatAppearance.BorderSize = 0;
            this.iconBtnSample.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnSample.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnSample.IconChar = FontAwesome.Sharp.IconChar.Microscope;
            this.iconBtnSample.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnSample.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnSample.IconSize = 32;
            this.iconBtnSample.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnSample.Location = new System.Drawing.Point(0, 242);
            this.iconBtnSample.Name = "iconBtnSample";
            this.iconBtnSample.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconBtnSample.Size = new System.Drawing.Size(175, 60);
            this.iconBtnSample.TabIndex = 3;
            this.iconBtnSample.Text = "样品测定";
            this.iconBtnSample.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnSample.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnSample.UseVisualStyleBackColor = false;
            this.iconBtnSample.Click += new System.EventHandler(this.iconBtnSample_Click);
            // 
            // iconBtnCalibration
            // 
            this.iconBtnCalibration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(171)))), ((int)(((byte)(230)))));
            this.iconBtnCalibration.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnCalibration.FlatAppearance.BorderSize = 0;
            this.iconBtnCalibration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnCalibration.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnCalibration.IconChar = FontAwesome.Sharp.IconChar.BalanceScale;
            this.iconBtnCalibration.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnCalibration.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnCalibration.IconSize = 32;
            this.iconBtnCalibration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnCalibration.Location = new System.Drawing.Point(0, 182);
            this.iconBtnCalibration.Name = "iconBtnCalibration";
            this.iconBtnCalibration.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconBtnCalibration.Size = new System.Drawing.Size(175, 60);
            this.iconBtnCalibration.TabIndex = 2;
            this.iconBtnCalibration.Text = "标定";
            this.iconBtnCalibration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnCalibration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnCalibration.UseVisualStyleBackColor = false;
            this.iconBtnCalibration.Click += new System.EventHandler(this.iconBtnCalibration_Click);
            // 
            // iconBtnConfigure
            // 
            this.iconBtnConfigure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(171)))), ((int)(((byte)(230)))));
            this.iconBtnConfigure.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnConfigure.FlatAppearance.BorderSize = 0;
            this.iconBtnConfigure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnConfigure.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnConfigure.IconChar = FontAwesome.Sharp.IconChar.Bong;
            this.iconBtnConfigure.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnConfigure.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnConfigure.IconSize = 32;
            this.iconBtnConfigure.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnConfigure.Location = new System.Drawing.Point(0, 122);
            this.iconBtnConfigure.Name = "iconBtnConfigure";
            this.iconBtnConfigure.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconBtnConfigure.Size = new System.Drawing.Size(175, 60);
            this.iconBtnConfigure.TabIndex = 1;
            this.iconBtnConfigure.Text = "实验配置";
            this.iconBtnConfigure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnConfigure.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnConfigure.UseVisualStyleBackColor = false;
            this.iconBtnConfigure.Click += new System.EventHandler(this.iconBtnConfigure_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Black;
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(175, 122);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Black;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(19, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(130, 119);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(157)))), ((int)(((byte)(215)))));
            this.panelTitleBar.Controls.Add(this.labTime);
            this.panelTitleBar.Controls.Add(this.labTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(175, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(827, 70);
            this.panelTitleBar.TabIndex = 2;
            // 
            // labTime
            // 
            this.labTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labTime.AutoSize = true;
            this.labTime.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTime.ForeColor = System.Drawing.Color.White;
            this.labTime.Location = new System.Drawing.Point(388, 27);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(76, 21);
            this.labTime.TabIndex = 2;
            this.labTime.Text = "label1";
            // 
            // labTitleChildForm
            // 
            this.labTitleChildForm.AutoSize = true;
            this.labTitleChildForm.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTitleChildForm.ForeColor = System.Drawing.Color.Silver;
            this.labTitleChildForm.Location = new System.Drawing.Point(57, 27);
            this.labTitleChildForm.Name = "labTitleChildForm";
            this.labTitleChildForm.Size = new System.Drawing.Size(60, 24);
            this.labTitleChildForm.TabIndex = 1;
            this.labTitleChildForm.Text = "主页";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.SlateBlue;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.SlateBlue;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 40;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(14, 17);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(40, 44);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelDesktop.Location = new System.Drawing.Point(175, 70);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(827, 561);
            this.panelDesktop.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(827, 561);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // dateTime
            // 
            this.dateTime.Enabled = true;
            this.dateTime.Interval = 1000;
            this.dateTime.Tick += new System.EventHandler(this.dateTime_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1002, 631);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主窗体";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconBtnConfigure;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconBtnDataProcessing;
        private FontAwesome.Sharp.IconButton iconBtnSample;
        private FontAwesome.Sharp.IconButton iconBtnCalibration;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label labTime;
        private SerialPort serialPort1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer dateTime;
        private FontAwesome.Sharp.IconButton iconBtnExperimentalTest;
        private FontAwesome.Sharp.IconButton iconBtnSetUp;
        private FontAwesome.Sharp.IconButton iconBtnAdditionalTool;
        private FontAwesome.Sharp.IconButton iconBtnPumpTest;
    }
}

