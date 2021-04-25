using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FrameTwo.Forms
{
    public partial class 附加工具 : Form
    {
        public 附加工具()
        {
            InitializeComponent();
        }

        #region 一元线性回归方程
        private void btnCalculation_Click(object sender, EventArgs e)
        {
            #region 计算
            double r = 0;//相关系数
            string[] xnum = richTextBox1.Text.Trim().Split(',');//x值
            string[] ynum = richTextBox2.Text.Trim().Split(',');//y值
            if (xnum.Length != ynum.Length)
            {
                MessageBox.Show("输入数据有误!");
                return;
            }
            labValueNumbers.Text = xnum.Length + "";//个数
            double xsum = 0;//x值求和
            double ysum = 0;//y值求和
            for (int i = 0; i < xnum.Length; i++)
            {
                xsum += Convert.ToDouble(xnum[i]);
                ysum += Convert.ToDouble(ynum[i]);
            }
            double xAve = Convert.ToDouble(xsum / xnum.Length);//x平均值
            double yAve = Convert.ToDouble(ysum / xnum.Length);//y平均值

            labxAve.Text = string.Format("{0:N}", xAve);//保留两位小数
            labyAve.Text = string.Format("{0:N}", yAve);

            double molecule = 0;//b(斜率)分子
            double Denominator = 0;//b(斜率)分母
            double rMolecule = 0;//r(相关系数)分子
            double rDenominator = 0;//r(相关系数)分母
            for (int i = 0; i < xnum.Length; i++)
            {
                molecule += (Convert.ToDouble(xnum[i]) - xAve) * (Convert.ToDouble(ynum[i]) - yAve);//
                Denominator += (Convert.ToDouble(xnum[i]) - xAve) * (Convert.ToDouble(xnum[i]) - xAve);
            }
            for (int i = 0; i < xnum.Length; i++)
            {
                rMolecule += Math.Pow((Convert.ToDouble(xnum[i]) - xAve), 2);
                rDenominator += Math.Pow((Convert.ToDouble(ynum[i]) - yAve), 2);
            }

            labSlope.Text = (molecule / Denominator).ToString("f3");//斜率
            labIntercept.Text = (yAve - (molecule / Denominator) * xAve).ToString("f3");//截距

            r = (molecule / Denominator) * Math.Sqrt(rMolecule / rDenominator);
            labCorrelation.Text = r.ToString();
            label20.Text = (r * r).ToString();

            if (Convert.ToDecimal(labIntercept.Text) < 0)
            {
                labEquation.Text = "y=" + labSlope.Text + "X" + labIntercept.Text;
            }
            else
            {
                labEquation.Text = "y=" + labSlope.Text + "X+" + labIntercept.Text;
            }
            #endregion

            #region 画点
            chart2.ChartAreas[0].AxisX.CustomLabels.Clear();
            chart2.Series[0].Color = Color.Red;
            chart2.Series[0].ChartType = SeriesChartType.Point;
            List<double?> lx = new List<double?>();
            List<double?> l1 = new List<double?>();
            for (int i = 1; i <= xnum.Length; i++)
            {
                CustomLabel label1 = new CustomLabel();
                if (xnum[i - 1] != "")
                {
                    label1.Text = Convert.ToDecimal(xnum[i - 1]).ToString();
                    label1.ToPosition = i * 2;
                    chart2.ChartAreas[0].AxisX.CustomLabels.Add(label1);
                    label1.GridTicks = GridTickTypes.Gridline;
                    lx.Add(i);
                    if (ynum[i - 1] == null)
                    {
                        l1.Add(null);
                    }
                    else
                    {
                        l1.Add(Convert.ToDouble(ynum[i - 1]));
                    }
                }
                chart2.Series[0].Points.DataBindXY(lx, l1);
            }
            #endregion
        }
        #endregion
    }
}
