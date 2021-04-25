namespace FrameTwo.Forms
{
    partial class 实验配置
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbmType = new System.Windows.Forms.ComboBox();
            this.CalibrationgroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cbmSolution = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.standSol5 = new System.Windows.Forms.NumericUpDown();
            this.standSol4 = new System.Windows.Forms.NumericUpDown();
            this.standSol3 = new System.Windows.Forms.NumericUpDown();
            this.standSol2 = new System.Windows.Forms.NumericUpDown();
            this.standSol1 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.portGroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDye3 = new System.Windows.Forms.TextBox();
            this.labDye3 = new System.Windows.Forms.Label();
            this.txtDye2 = new System.Windows.Forms.TextBox();
            this.labDye2 = new System.Windows.Forms.Label();
            this.txtDye1 = new System.Windows.Forms.TextBox();
            this.labDye1 = new System.Windows.Forms.Label();
            this.txtReactionTank = new System.Windows.Forms.TextBox();
            this.txtWasteLiquid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPureWater = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeater = new System.Windows.Forms.TextBox();
            this.labHeater = new System.Windows.Forms.Label();
            this.txtSample = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenOrClose = new System.Windows.Forms.Button();
            this.cmbPorts = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CalibrationgroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.standSol5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standSol4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standSol3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standSol2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standSol1)).BeginInit();
            this.portGroupBox1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbmType
            // 
            this.cbmType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmType.FormattingEnabled = true;
            this.cbmType.Items.AddRange(new object[] {
            "硝酸盐",
            "亚硝酸盐",
            "氨氮",
            "磷酸盐",
            "硅酸盐"});
            this.cbmType.Location = new System.Drawing.Point(404, 55);
            this.cbmType.Name = "cbmType";
            this.cbmType.Size = new System.Drawing.Size(103, 27);
            this.cbmType.TabIndex = 31;
            this.cbmType.SelectedIndexChanged += new System.EventHandler(this.cbmType_SelectedIndexChanged);
            // 
            // CalibrationgroupBox1
            // 
            this.CalibrationgroupBox1.Controls.Add(this.btnCheck);
            this.CalibrationgroupBox1.Controls.Add(this.btnUpdate);
            this.CalibrationgroupBox1.Controls.Add(this.btnReset);
            this.CalibrationgroupBox1.Controls.Add(this.cbmSolution);
            this.CalibrationgroupBox1.Controls.Add(this.label19);
            this.CalibrationgroupBox1.Controls.Add(this.label21);
            this.CalibrationgroupBox1.Controls.Add(this.label18);
            this.CalibrationgroupBox1.Controls.Add(this.label17);
            this.CalibrationgroupBox1.Controls.Add(this.label16);
            this.CalibrationgroupBox1.Controls.Add(this.label15);
            this.CalibrationgroupBox1.Controls.Add(this.standSol5);
            this.CalibrationgroupBox1.Controls.Add(this.standSol4);
            this.CalibrationgroupBox1.Controls.Add(this.standSol3);
            this.CalibrationgroupBox1.Controls.Add(this.standSol2);
            this.CalibrationgroupBox1.Controls.Add(this.standSol1);
            this.CalibrationgroupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CalibrationgroupBox1.ForeColor = System.Drawing.Color.White;
            this.CalibrationgroupBox1.Location = new System.Drawing.Point(39, 191);
            this.CalibrationgroupBox1.Name = "CalibrationgroupBox1";
            this.CalibrationgroupBox1.Size = new System.Drawing.Size(295, 252);
            this.CalibrationgroupBox1.TabIndex = 5;
            this.CalibrationgroupBox1.TabStop = false;
            this.CalibrationgroupBox1.Text = "标液浓度";
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCheck.ForeColor = System.Drawing.Color.Black;
            this.btnCheck.Location = new System.Drawing.Point(194, 192);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(72, 30);
            this.btnCheck.TabIndex = 29;
            this.btnCheck.Text = "查看";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(194, 149);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(72, 30);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(194, 104);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(72, 31);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbmSolution
            // 
            this.cbmSolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmSolution.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbmSolution.FormattingEnabled = true;
            this.cbmSolution.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbmSolution.Location = new System.Drawing.Point(212, 34);
            this.cbmSolution.Name = "cbmSolution";
            this.cbmSolution.Size = new System.Drawing.Size(54, 24);
            this.cbmSolution.TabIndex = 28;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(18, 199);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 16);
            this.label19.TabIndex = 25;
            this.label19.Text = "浓度5:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(168, 38);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(48, 16);
            this.label21.TabIndex = 27;
            this.label21.Text = "数量:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(18, 156);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 16);
            this.label18.TabIndex = 24;
            this.label18.Text = "浓度4:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(18, 115);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 16);
            this.label17.TabIndex = 23;
            this.label17.Text = "浓度3:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(18, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 16);
            this.label16.TabIndex = 22;
            this.label16.Text = "浓度2:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(18, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 16);
            this.label15.TabIndex = 21;
            this.label15.Text = "浓度1:";
            // 
            // standSol5
            // 
            this.standSol5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.standSol5.Location = new System.Drawing.Point(80, 199);
            this.standSol5.Name = "standSol5";
            this.standSol5.Size = new System.Drawing.Size(45, 23);
            this.standSol5.TabIndex = 20;
            this.standSol5.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // standSol4
            // 
            this.standSol4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.standSol4.Location = new System.Drawing.Point(80, 156);
            this.standSol4.Name = "standSol4";
            this.standSol4.Size = new System.Drawing.Size(45, 23);
            this.standSol4.TabIndex = 19;
            this.standSol4.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // standSol3
            // 
            this.standSol3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.standSol3.Location = new System.Drawing.Point(80, 115);
            this.standSol3.Name = "standSol3";
            this.standSol3.Size = new System.Drawing.Size(45, 23);
            this.standSol3.TabIndex = 18;
            this.standSol3.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // standSol2
            // 
            this.standSol2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.standSol2.Location = new System.Drawing.Point(80, 75);
            this.standSol2.Name = "standSol2";
            this.standSol2.Size = new System.Drawing.Size(45, 23);
            this.standSol2.TabIndex = 17;
            this.standSol2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // standSol1
            // 
            this.standSol1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.standSol1.Location = new System.Drawing.Point(80, 35);
            this.standSol1.Name = "standSol1";
            this.standSol1.Size = new System.Drawing.Size(45, 23);
            this.standSol1.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("幼圆", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(288, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "当前测定物质:";
            // 
            // portGroupBox1
            // 
            this.portGroupBox1.Controls.Add(this.txtDye3);
            this.portGroupBox1.Controls.Add(this.labDye3);
            this.portGroupBox1.Controls.Add(this.txtDye2);
            this.portGroupBox1.Controls.Add(this.labDye2);
            this.portGroupBox1.Controls.Add(this.txtDye1);
            this.portGroupBox1.Controls.Add(this.labDye1);
            this.portGroupBox1.Controls.Add(this.txtReactionTank);
            this.portGroupBox1.Controls.Add(this.txtWasteLiquid);
            this.portGroupBox1.Controls.Add(this.label5);
            this.portGroupBox1.Controls.Add(this.txtPureWater);
            this.portGroupBox1.Controls.Add(this.label4);
            this.portGroupBox1.Controls.Add(this.label3);
            this.portGroupBox1.Controls.Add(this.txtHeater);
            this.portGroupBox1.Controls.Add(this.labHeater);
            this.portGroupBox1.Controls.Add(this.txtSample);
            this.portGroupBox1.Controls.Add(this.label6);
            this.portGroupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.portGroupBox1.ForeColor = System.Drawing.Color.White;
            this.portGroupBox1.Location = new System.Drawing.Point(353, 191);
            this.portGroupBox1.Name = "portGroupBox1";
            this.portGroupBox1.Size = new System.Drawing.Size(295, 252);
            this.portGroupBox1.TabIndex = 1;
            this.portGroupBox1.TabStop = false;
            this.portGroupBox1.Text = "泵端口";
            // 
            // txtDye3
            // 
            this.txtDye3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDye3.Location = new System.Drawing.Point(239, 119);
            this.txtDye3.Name = "txtDye3";
            this.txtDye3.Size = new System.Drawing.Size(27, 26);
            this.txtDye3.TabIndex = 11;
            this.txtDye3.Text = "8";
            this.txtDye3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labDye3
            // 
            this.labDye3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labDye3.Location = new System.Drawing.Point(130, 122);
            this.labDye3.Name = "labDye3";
            this.labDye3.Size = new System.Drawing.Size(120, 16);
            this.labDye3.TabIndex = 10;
            this.labDye3.Text = "CCl3:";
            this.labDye3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDye2
            // 
            this.txtDye2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDye2.Location = new System.Drawing.Point(239, 76);
            this.txtDye2.Name = "txtDye2";
            this.txtDye2.Size = new System.Drawing.Size(27, 26);
            this.txtDye2.TabIndex = 9;
            this.txtDye2.Text = "7";
            this.txtDye2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labDye2
            // 
            this.labDye2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labDye2.Location = new System.Drawing.Point(120, 79);
            this.labDye2.Name = "labDye2";
            this.labDye2.Size = new System.Drawing.Size(130, 16);
            this.labDye2.TabIndex = 8;
            this.labDye2.Text = "NED:";
            this.labDye2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDye1
            // 
            this.txtDye1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDye1.Location = new System.Drawing.Point(239, 33);
            this.txtDye1.Name = "txtDye1";
            this.txtDye1.Size = new System.Drawing.Size(27, 26);
            this.txtDye1.TabIndex = 7;
            this.txtDye1.Text = "6";
            this.txtDye1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labDye1
            // 
            this.labDye1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labDye1.Location = new System.Drawing.Point(129, 36);
            this.labDye1.Name = "labDye1";
            this.labDye1.Size = new System.Drawing.Size(120, 16);
            this.labDye1.TabIndex = 6;
            this.labDye1.Text = "SAM:";
            this.labDye1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtReactionTank
            // 
            this.txtReactionTank.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtReactionTank.Location = new System.Drawing.Point(90, 205);
            this.txtReactionTank.Name = "txtReactionTank";
            this.txtReactionTank.Size = new System.Drawing.Size(27, 26);
            this.txtReactionTank.TabIndex = 3;
            this.txtReactionTank.Text = "2";
            this.txtReactionTank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWasteLiquid
            // 
            this.txtWasteLiquid.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtWasteLiquid.Location = new System.Drawing.Point(90, 161);
            this.txtWasteLiquid.Name = "txtWasteLiquid";
            this.txtWasteLiquid.Size = new System.Drawing.Size(27, 26);
            this.txtWasteLiquid.TabIndex = 3;
            this.txtWasteLiquid.Text = "9";
            this.txtWasteLiquid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(32, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "流通池:";
            // 
            // txtPureWater
            // 
            this.txtPureWater.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPureWater.Location = new System.Drawing.Point(90, 119);
            this.txtPureWater.Name = "txtPureWater";
            this.txtPureWater.Size = new System.Drawing.Size(27, 26);
            this.txtPureWater.TabIndex = 5;
            this.txtPureWater.Text = "3";
            this.txtPureWater.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(48, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "废液:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(48, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "纯水:";
            // 
            // txtHeater
            // 
            this.txtHeater.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtHeater.Location = new System.Drawing.Point(90, 76);
            this.txtHeater.Name = "txtHeater";
            this.txtHeater.Size = new System.Drawing.Size(27, 26);
            this.txtHeater.TabIndex = 3;
            this.txtHeater.Text = "2";
            this.txtHeater.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labHeater
            // 
            this.labHeater.AutoSize = true;
            this.labHeater.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labHeater.Location = new System.Drawing.Point(32, 79);
            this.labHeater.Name = "labHeater";
            this.labHeater.Size = new System.Drawing.Size(64, 16);
            this.labHeater.TabIndex = 2;
            this.labHeater.Text = "加热棒:";
            this.labHeater.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSample
            // 
            this.txtSample.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSample.Location = new System.Drawing.Point(90, 33);
            this.txtSample.Name = "txtSample";
            this.txtSample.Size = new System.Drawing.Size(27, 26);
            this.txtSample.TabIndex = 1;
            this.txtSample.Text = "1";
            this.txtSample.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(48, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "样品:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpenOrClose);
            this.groupBox1.Controls.Add(this.cmbPorts);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(39, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口配置";
            // 
            // btnOpenOrClose
            // 
            this.btnOpenOrClose.BackColor = System.Drawing.Color.Green;
            this.btnOpenOrClose.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenOrClose.Location = new System.Drawing.Point(31, 83);
            this.btnOpenOrClose.Name = "btnOpenOrClose";
            this.btnOpenOrClose.Size = new System.Drawing.Size(158, 37);
            this.btnOpenOrClose.TabIndex = 2;
            this.btnOpenOrClose.Text = "打开串口";
            this.btnOpenOrClose.UseVisualStyleBackColor = false;
            this.btnOpenOrClose.Click += new System.EventHandler(this.btnOpenOrClose_Click);
            // 
            // cmbPorts
            // 
            this.cmbPorts.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbPorts.FormattingEnabled = true;
            this.cmbPorts.Location = new System.Drawing.Point(84, 37);
            this.cmbPorts.Name = "cmbPorts";
            this.cmbPorts.Size = new System.Drawing.Size(105, 29);
            this.cmbPorts.TabIndex = 1;
            this.cmbPorts.Click += new System.EventHandler(this.cmbPorts_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(27, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "端口号:";
            // 
            // 实验配置
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(128)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(839, 552);
            this.Controls.Add(this.cbmType);
            this.Controls.Add(this.CalibrationgroupBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.portGroupBox1);
            this.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "实验配置";
            this.Text = "实验配置";
            this.Load += new System.EventHandler(this.实验配置_Load);
            this.CalibrationgroupBox1.ResumeLayout(false);
            this.CalibrationgroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.standSol5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standSol4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standSol3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standSol2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standSol1)).EndInit();
            this.portGroupBox1.ResumeLayout(false);
            this.portGroupBox1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPorts;
        private System.Windows.Forms.Button btnOpenOrClose;
        private System.Windows.Forms.GroupBox CalibrationgroupBox1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cbmSolution;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown standSol5;
        private System.Windows.Forms.NumericUpDown standSol4;
        private System.Windows.Forms.NumericUpDown standSol3;
        private System.Windows.Forms.NumericUpDown standSol2;
        private System.Windows.Forms.NumericUpDown standSol1;
        private System.Windows.Forms.GroupBox portGroupBox1;
        private System.Windows.Forms.TextBox txtDye3;
        private System.Windows.Forms.Label labDye3;
        private System.Windows.Forms.TextBox txtDye2;
        private System.Windows.Forms.Label labDye2;
        private System.Windows.Forms.TextBox txtDye1;
        private System.Windows.Forms.Label labDye1;
        private System.Windows.Forms.TextBox txtReactionTank;
        private System.Windows.Forms.TextBox txtWasteLiquid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPureWater;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHeater;
        private System.Windows.Forms.Label labHeater;
        private System.Windows.Forms.TextBox txtSample;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbmType;
        private System.Windows.Forms.Label label9;
    }
}