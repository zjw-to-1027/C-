namespace FrameTwo.Forms
{
    partial class 实验测试
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labCurrentTask = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbmTestType = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.dgvTesting = new Sunny.UI.UIDataGridView();
            this.Solution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LightIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LightOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Absorbance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnWash = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.taskTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbmNumber = new System.Windows.Forms.ComboBox();
            this.cbmConcentration = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.showValueTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.cbmTestType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTesting)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(29, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(774, 97);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "监控模块";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labCurrentTask);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(413, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 68);
            this.panel2.TabIndex = 7;
            // 
            // labCurrentTask
            // 
            this.labCurrentTask.AutoSize = true;
            this.labCurrentTask.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCurrentTask.Location = new System.Drawing.Point(104, 9);
            this.labCurrentTask.Name = "labCurrentTask";
            this.labCurrentTask.Size = new System.Drawing.Size(54, 21);
            this.labCurrentTask.TabIndex = 6;
            this.labCurrentTask.Text = "null";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 35);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(306, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(8, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 21);
            this.label10.TabIndex = 5;
            this.label10.Text = "当前任务:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(143, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "null";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(26, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "流通池光强:";
            // 
            // cbmTestType
            // 
            this.cbmTestType.Controls.Add(this.cbmConcentration);
            this.cbmTestType.Controls.Add(this.label4);
            this.cbmTestType.Controls.Add(this.cbmNumber);
            this.cbmTestType.Controls.Add(this.label3);
            this.cbmTestType.Controls.Add(this.label1);
            this.cbmTestType.Controls.Add(this.btnInit);
            this.cbmTestType.Controls.Add(this.btnWash);
            this.cbmTestType.Controls.Add(this.dgvTesting);
            this.cbmTestType.Controls.Add(this.btnStart);
            this.cbmTestType.Controls.Add(this.comboBox1);
            this.cbmTestType.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbmTestType.ForeColor = System.Drawing.Color.White;
            this.cbmTestType.Location = new System.Drawing.Point(29, 115);
            this.cbmTestType.Name = "cbmTestType";
            this.cbmTestType.Size = new System.Drawing.Size(774, 387);
            this.cbmTestType.TabIndex = 29;
            this.cbmTestType.TabStop = false;
            this.cbmTestType.Text = "测试";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "重现性"});
            this.comboBox1.Location = new System.Drawing.Point(126, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnStart
            // 
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(31, 317);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(121, 34);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "开 始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // dgvTesting
            // 
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvTesting.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvTesting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTesting.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTesting.BackgroundColor = System.Drawing.Color.White;
            this.dgvTesting.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTesting.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvTesting.ColumnHeadersHeight = 32;
            this.dgvTesting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTesting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Solution,
            this.LightIn,
            this.LightOut,
            this.Absorbance});
            this.dgvTesting.EnableHeadersVisualStyles = false;
            this.dgvTesting.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgvTesting.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvTesting.Location = new System.Drawing.Point(356, 21);
            this.dgvTesting.Name = "dgvTesting";
            this.dgvTesting.RowHeadersVisible = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            this.dgvTesting.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvTesting.RowTemplate.Height = 29;
            this.dgvTesting.SelectedIndex = -1;
            this.dgvTesting.ShowGridLine = true;
            this.dgvTesting.Size = new System.Drawing.Size(383, 357);
            this.dgvTesting.TabIndex = 67;
            // 
            // Solution
            // 
            dataGridViewCellStyle17.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            this.Solution.DefaultCellStyle = dataGridViewCellStyle17;
            this.Solution.HeaderText = "标液";
            this.Solution.Name = "Solution";
            this.Solution.ReadOnly = true;
            // 
            // LightIn
            // 
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            this.LightIn.DefaultCellStyle = dataGridViewCellStyle18;
            this.LightIn.HeaderText = "入射光";
            this.LightIn.Name = "LightIn";
            this.LightIn.ReadOnly = true;
            // 
            // LightOut
            // 
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            this.LightOut.DefaultCellStyle = dataGridViewCellStyle19;
            this.LightOut.HeaderText = "透射光";
            this.LightOut.Name = "LightOut";
            this.LightOut.ReadOnly = true;
            // 
            // Absorbance
            // 
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            this.Absorbance.DefaultCellStyle = dataGridViewCellStyle20;
            this.Absorbance.HeaderText = "吸光度";
            this.Absorbance.Name = "Absorbance";
            this.Absorbance.ReadOnly = true;
            // 
            // btnWash
            // 
            this.btnWash.ForeColor = System.Drawing.Color.Black;
            this.btnWash.Location = new System.Drawing.Point(31, 266);
            this.btnWash.Name = "btnWash";
            this.btnWash.Size = new System.Drawing.Size(121, 34);
            this.btnWash.TabIndex = 68;
            this.btnWash.Text = "清 洗";
            this.btnWash.UseVisualStyleBackColor = true;
            this.btnWash.Click += new System.EventHandler(this.btnWash_Click);
            // 
            // btnInit
            // 
            this.btnInit.ForeColor = System.Drawing.Color.Black;
            this.btnInit.Location = new System.Drawing.Point(31, 215);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(121, 34);
            this.btnInit.TabIndex = 69;
            this.btnInit.Text = "初始化";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // taskTimer
            // 
            this.taskTimer.Tick += new System.EventHandler(this.taskTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 70;
            this.label1.Text = "测试项目:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 71;
            this.label3.Text = "测试数量:";
            // 
            // cbmNumber
            // 
            this.cbmNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmNumber.FormattingEnabled = true;
            this.cbmNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbmNumber.Location = new System.Drawing.Point(126, 138);
            this.cbmNumber.Name = "cbmNumber";
            this.cbmNumber.Size = new System.Drawing.Size(121, 27);
            this.cbmNumber.TabIndex = 72;
            // 
            // cbmConcentration
            // 
            this.cbmConcentration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmConcentration.FormattingEnabled = true;
            this.cbmConcentration.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbmConcentration.Location = new System.Drawing.Point(126, 92);
            this.cbmConcentration.Name = "cbmConcentration";
            this.cbmConcentration.Size = new System.Drawing.Size(121, 27);
            this.cbmConcentration.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 19);
            this.label4.TabIndex = 73;
            this.label4.Text = "测试浓度:";
            // 
            // showValueTimer
            // 
            this.showValueTimer.Enabled = true;
            this.showValueTimer.Tick += new System.EventHandler(this.showValueTimer_Tick);
            // 
            // 实验测试
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(827, 514);
            this.Controls.Add(this.cbmTestType);
            this.Controls.Add(this.groupBox2);
            this.Name = "实验测试";
            this.Text = "实验测试";
            this.Load += new System.EventHandler(this.实验测试_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.cbmTestType.ResumeLayout(false);
            this.cbmTestType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTesting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labCurrentTask;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox cbmTestType;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnStart;
        private Sunny.UI.UIDataGridView dgvTesting;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solution;
        private System.Windows.Forms.DataGridViewTextBoxColumn LightIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LightOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Absorbance;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnWash;
        private System.Windows.Forms.Timer taskTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbmNumber;
        private System.Windows.Forms.ComboBox cbmConcentration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer showValueTimer;
    }
}