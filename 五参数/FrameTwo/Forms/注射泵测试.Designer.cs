namespace FrameTwo.Forms
{
    partial class 注射泵测试
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
            this.txtPumpCmd = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPumpSent = new System.Windows.Forms.Button();
            this.txtCmd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPumpCmd
            // 
            this.txtPumpCmd.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPumpCmd.Location = new System.Drawing.Point(31, 142);
            this.txtPumpCmd.Multiline = true;
            this.txtPumpCmd.Name = "txtPumpCmd";
            this.txtPumpCmd.Size = new System.Drawing.Size(356, 187);
            this.txtPumpCmd.TabIndex = 9;
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExport.Location = new System.Drawing.Point(499, 138);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 32);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "导出";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnPumpSent
            // 
            this.btnPumpSent.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPumpSent.Location = new System.Drawing.Point(499, 52);
            this.btnPumpSent.Name = "btnPumpSent";
            this.btnPumpSent.Size = new System.Drawing.Size(75, 29);
            this.btnPumpSent.TabIndex = 7;
            this.btnPumpSent.Text = "发送";
            this.btnPumpSent.UseVisualStyleBackColor = true;
            this.btnPumpSent.Click += new System.EventHandler(this.btnPumpSent_Click);
            // 
            // txtCmd
            // 
            this.txtCmd.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCmd.Location = new System.Drawing.Point(31, 52);
            this.txtCmd.Name = "txtCmd";
            this.txtCmd.Size = new System.Drawing.Size(356, 29);
            this.txtCmd.TabIndex = 6;
            this.txtCmd.Text = "ZR";
            // 
            // 注射泵测试
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(839, 552);
            this.Controls.Add(this.txtPumpCmd);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnPumpSent);
            this.Controls.Add(this.txtCmd);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "注射泵测试";
            this.Text = "注射泵测试";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPumpCmd;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPumpSent;
        private System.Windows.Forms.TextBox txtCmd;
    }
}