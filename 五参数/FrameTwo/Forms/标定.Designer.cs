namespace FrameTwo.Forms
{
    partial class 标定
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvResult = new Sunny.UI.UIDataGridView();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCalibration = new Sunny.UI.UIDataGridView();
            this.Solution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LightIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LightOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Absorbance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labCurrentTask = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCloseA = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.btnWash = new System.Windows.Forms.Button();
            this.btnGetA = new System.Windows.Forms.Button();
            this.btnCalibration = new System.Windows.Forms.Button();
            this.taskTimer = new System.Windows.Forms.Timer(this.components);
            this.showValueTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalibration)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvResult);
            this.groupBox1.Controls.Add(this.dgvCalibration);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(369, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 351);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "实验数据";
            // 
            // dgvResult
            // 
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle34;
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResult.BackgroundColor = System.Drawing.Color.White;
            this.dgvResult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle35.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.dgvResult.ColumnHeadersHeight = 32;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Result});
            this.dgvResult.EnableHeadersVisualStyles = false;
            this.dgvResult.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgvResult.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvResult.Location = new System.Drawing.Point(25, 208);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowHeadersVisible = false;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.White;
            this.dgvResult.RowsDefaultCellStyle = dataGridViewCellStyle37;
            this.dgvResult.RowTemplate.Height = 29;
            this.dgvResult.SelectedIndex = -1;
            this.dgvResult.ShowGridLine = true;
            this.dgvResult.Size = new System.Drawing.Size(383, 122);
            this.dgvResult.TabIndex = 68;
            // 
            // Result
            // 
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.Black;
            this.Result.DefaultCellStyle = dataGridViewCellStyle36;
            this.Result.HeaderText = "Result";
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            // 
            // dgvCalibration
            // 
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvCalibration.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle38;
            this.dgvCalibration.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCalibration.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCalibration.BackgroundColor = System.Drawing.Color.White;
            this.dgvCalibration.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle39.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle39.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCalibration.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.dgvCalibration.ColumnHeadersHeight = 32;
            this.dgvCalibration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCalibration.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Solution,
            this.LightIn,
            this.LightOut,
            this.Absorbance});
            this.dgvCalibration.EnableHeadersVisualStyles = false;
            this.dgvCalibration.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgvCalibration.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvCalibration.Location = new System.Drawing.Point(25, 30);
            this.dgvCalibration.Name = "dgvCalibration";
            this.dgvCalibration.RowHeadersVisible = false;
            dataGridViewCellStyle44.BackColor = System.Drawing.Color.White;
            this.dgvCalibration.RowsDefaultCellStyle = dataGridViewCellStyle44;
            this.dgvCalibration.RowTemplate.Height = 29;
            this.dgvCalibration.SelectedIndex = -1;
            this.dgvCalibration.ShowGridLine = true;
            this.dgvCalibration.Size = new System.Drawing.Size(383, 180);
            this.dgvCalibration.TabIndex = 67;
            // 
            // Solution
            // 
            dataGridViewCellStyle40.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.Color.Black;
            this.Solution.DefaultCellStyle = dataGridViewCellStyle40;
            this.Solution.HeaderText = "标液";
            this.Solution.Name = "Solution";
            this.Solution.ReadOnly = true;
            // 
            // LightIn
            // 
            dataGridViewCellStyle41.ForeColor = System.Drawing.Color.Black;
            this.LightIn.DefaultCellStyle = dataGridViewCellStyle41;
            this.LightIn.HeaderText = "入射光";
            this.LightIn.Name = "LightIn";
            this.LightIn.ReadOnly = true;
            // 
            // LightOut
            // 
            dataGridViewCellStyle42.ForeColor = System.Drawing.Color.Black;
            this.LightOut.DefaultCellStyle = dataGridViewCellStyle42;
            this.LightOut.HeaderText = "透射光";
            this.LightOut.Name = "LightOut";
            this.LightOut.ReadOnly = true;
            // 
            // Absorbance
            // 
            dataGridViewCellStyle43.ForeColor = System.Drawing.Color.Black;
            this.Absorbance.DefaultCellStyle = dataGridViewCellStyle43;
            this.Absorbance.HeaderText = "吸光度";
            this.Absorbance.Name = "Absorbance";
            this.Absorbance.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(26, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(774, 97);
            this.groupBox2.TabIndex = 27;
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.btnCloseA);
            this.groupBox4.Controls.Add(this.btnInit);
            this.groupBox4.Controls.Add(this.btnWash);
            this.groupBox4.Controls.Add(this.btnGetA);
            this.groupBox4.Controls.Add(this.btnCalibration);
            this.groupBox4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(26, 170);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(285, 224);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "实验";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(30, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 68;
            this.button1.Text = "全部清洗";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCloseA
            // 
            this.btnCloseA.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCloseA.ForeColor = System.Drawing.Color.Black;
            this.btnCloseA.Location = new System.Drawing.Point(157, 175);
            this.btnCloseA.Name = "btnCloseA";
            this.btnCloseA.Size = new System.Drawing.Size(100, 33);
            this.btnCloseA.TabIndex = 67;
            this.btnCloseA.Text = "CloseA";
            this.btnCloseA.UseVisualStyleBackColor = true;
            this.btnCloseA.Click += new System.EventHandler(this.btnCloseA_Click);
            // 
            // btnInit
            // 
            this.btnInit.ForeColor = System.Drawing.Color.Black;
            this.btnInit.Location = new System.Drawing.Point(30, 33);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(100, 34);
            this.btnInit.TabIndex = 9;
            this.btnInit.Text = "初始化";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // btnWash
            // 
            this.btnWash.ForeColor = System.Drawing.Color.Black;
            this.btnWash.Location = new System.Drawing.Point(157, 33);
            this.btnWash.Name = "btnWash";
            this.btnWash.Size = new System.Drawing.Size(100, 34);
            this.btnWash.TabIndex = 8;
            this.btnWash.Text = "清洗";
            this.btnWash.UseVisualStyleBackColor = true;
            this.btnWash.Click += new System.EventHandler(this.btnWash_Click);
            // 
            // btnGetA
            // 
            this.btnGetA.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGetA.ForeColor = System.Drawing.Color.Black;
            this.btnGetA.Location = new System.Drawing.Point(30, 175);
            this.btnGetA.Name = "btnGetA";
            this.btnGetA.Size = new System.Drawing.Size(100, 33);
            this.btnGetA.TabIndex = 0;
            this.btnGetA.Text = "GetA";
            this.btnGetA.UseVisualStyleBackColor = true;
            this.btnGetA.Click += new System.EventHandler(this.btnGetA_Click);
            // 
            // btnCalibration
            // 
            this.btnCalibration.ForeColor = System.Drawing.Color.Black;
            this.btnCalibration.Location = new System.Drawing.Point(157, 104);
            this.btnCalibration.Name = "btnCalibration";
            this.btnCalibration.Size = new System.Drawing.Size(100, 34);
            this.btnCalibration.TabIndex = 0;
            this.btnCalibration.Text = "标定";
            this.btnCalibration.UseVisualStyleBackColor = true;
            this.btnCalibration.Click += new System.EventHandler(this.btnCalibration_Click);
            // 
            // taskTimer
            // 
            this.taskTimer.Tick += new System.EventHandler(this.taskTimer_Tick);
            // 
            // showValueTimer
            // 
            this.showValueTimer.Enabled = true;
            this.showValueTimer.Tick += new System.EventHandler(this.showValueTimer_Tick);
            // 
            // 标定
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(851, 566);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Name = "标定";
            this.Text = "标定";
            this.Load += new System.EventHandler(this.标定_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalibration)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnWash;
        private System.Windows.Forms.Button btnCalibration;
        private System.Windows.Forms.Timer taskTimer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labCurrentTask;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetA;
        private System.Windows.Forms.Timer showValueTimer;
        private System.Windows.Forms.Button btnCloseA;
        private Sunny.UI.UIDataGridView dgvCalibration;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solution;
        private System.Windows.Forms.DataGridViewTextBoxColumn LightIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LightOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Absorbance;
        private Sunny.UI.UIDataGridView dgvResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
    }
}