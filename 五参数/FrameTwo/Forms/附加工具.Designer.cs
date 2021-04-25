namespace FrameTwo.Forms
{
    partial class 附加工具
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.labCorrelation = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.labEquation = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.labIntercept = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.labSlope = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.labyAve = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.labxAve = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.labValueNumbers = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCalculation = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(1016, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "附加工具";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(194, 398);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(16, 16);
            this.label20.TabIndex = 50;
            this.label20.Text = "0";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(166, 398);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(32, 16);
            this.label27.TabIndex = 49;
            this.label27.Text = "R2:";
            // 
            // labCorrelation
            // 
            this.labCorrelation.AutoSize = true;
            this.labCorrelation.Location = new System.Drawing.Point(194, 367);
            this.labCorrelation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCorrelation.Name = "labCorrelation";
            this.labCorrelation.Size = new System.Drawing.Size(16, 16);
            this.labCorrelation.TabIndex = 48;
            this.labCorrelation.Text = "0";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(118, 367);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(80, 16);
            this.label25.TabIndex = 47;
            this.label25.Text = "相关系数:";
            // 
            // labEquation
            // 
            this.labEquation.AutoSize = true;
            this.labEquation.Location = new System.Drawing.Point(194, 432);
            this.labEquation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labEquation.Name = "labEquation";
            this.labEquation.Size = new System.Drawing.Size(16, 16);
            this.labEquation.TabIndex = 46;
            this.labEquation.Text = "0";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(86, 432);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(112, 16);
            this.label28.TabIndex = 45;
            this.label28.Text = "线性回归方程:";
            // 
            // labIntercept
            // 
            this.labIntercept.AutoSize = true;
            this.labIntercept.Location = new System.Drawing.Point(194, 335);
            this.labIntercept.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labIntercept.Name = "labIntercept";
            this.labIntercept.Size = new System.Drawing.Size(16, 16);
            this.labIntercept.TabIndex = 44;
            this.labIntercept.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(150, 335);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(48, 16);
            this.label23.TabIndex = 43;
            this.label23.Text = "截距:";
            // 
            // labSlope
            // 
            this.labSlope.AutoSize = true;
            this.labSlope.Location = new System.Drawing.Point(194, 303);
            this.labSlope.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labSlope.Name = "labSlope";
            this.labSlope.Size = new System.Drawing.Size(16, 16);
            this.labSlope.TabIndex = 42;
            this.labSlope.Text = "0";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(150, 303);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(48, 16);
            this.label26.TabIndex = 41;
            this.label26.Text = "斜率:";
            // 
            // labyAve
            // 
            this.labyAve.AutoSize = true;
            this.labyAve.Location = new System.Drawing.Point(194, 271);
            this.labyAve.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labyAve.Name = "labyAve";
            this.labyAve.Size = new System.Drawing.Size(16, 16);
            this.labyAve.TabIndex = 40;
            this.labyAve.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(126, 271);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(72, 16);
            this.label24.TabIndex = 39;
            this.label24.Text = "Y平均值:";
            // 
            // labxAve
            // 
            this.labxAve.AutoSize = true;
            this.labxAve.Location = new System.Drawing.Point(194, 239);
            this.labxAve.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labxAve.Name = "labxAve";
            this.labxAve.Size = new System.Drawing.Size(16, 16);
            this.labxAve.TabIndex = 38;
            this.labxAve.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(126, 239);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(72, 16);
            this.label22.TabIndex = 37;
            this.label22.Text = "X平均值:";
            // 
            // labValueNumbers
            // 
            this.labValueNumbers.AutoSize = true;
            this.labValueNumbers.Location = new System.Drawing.Point(194, 207);
            this.labValueNumbers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labValueNumbers.Name = "labValueNumbers";
            this.labValueNumbers.Size = new System.Drawing.Size(16, 16);
            this.labValueNumbers.TabIndex = 36;
            this.labValueNumbers.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(118, 207);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 16);
            this.label13.TabIndex = 35;
            this.label13.Text = "输入个数:";
            // 
            // btnCalculation
            // 
            this.btnCalculation.Location = new System.Drawing.Point(105, 143);
            this.btnCalculation.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculation.Name = "btnCalculation";
            this.btnCalculation.Size = new System.Drawing.Size(81, 32);
            this.btnCalculation.TabIndex = 34;
            this.btnCalculation.Text = "计算";
            this.btnCalculation.UseVisualStyleBackColor = true;
            this.btnCalculation.Click += new System.EventHandler(this.btnCalculation_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(27, 94);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 24);
            this.label12.TabIndex = 33;
            this.label12.Text = "值Y=";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(27, 30);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 24);
            this.label11.TabIndex = 32;
            this.label11.Text = "值X=";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(105, 84);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(646, 34);
            this.richTextBox2.TabIndex = 31;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(105, 20);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(646, 34);
            this.richTextBox1.TabIndex = 30;
            this.richTextBox1.Text = "";
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(341, 203);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(486, 337);
            this.chart2.TabIndex = 51;
            this.chart2.Text = "chart1";
            // 
            // 附加工具
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(839, 552);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.labCorrelation);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.labEquation);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.labIntercept);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.labSlope);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.labyAve);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.labxAve);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.labValueNumbers);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnCalculation);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "附加工具";
            this.Text = "附加工具";
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label labCorrelation;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label labEquation;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label labIntercept;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label labSlope;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label labyAve;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label labxAve;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label labValueNumbers;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCalculation;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}