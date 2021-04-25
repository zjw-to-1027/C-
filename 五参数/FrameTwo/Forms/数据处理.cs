using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrameTwo.Forms
{
    public partial class 数据处理 : Form
    {
        public 数据处理()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Text += "入射光 \t";
            textBox1.Text += "透射光 \t";
            textBox1.Text += "吸光度 \t";
            textBox1.Text += "\r\n";
            for (int i = 0; i < NitriteExpData.LightIn.Length; i++)
            {
                textBox1.Text += (NitriteExpData.LightIn[i]).ToString().Substring(0, 5) + " \t";
                textBox1.Text += (NitriteExpData.LightOut[i]).ToString().Substring(0, 5) + " \t";
                textBox1.Text += (NitriteExpData.Absorbance[i]).ToString().Substring(0, 5) + " \t";
                textBox1.Text += "\r\n";
            }
        }
    }
}
