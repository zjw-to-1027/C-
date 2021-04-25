using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using FrameTwo.Forms;

namespace FrameTwo
{
    public partial class FrmMain : Form
    {
        #region 字段、变量
        private int num = 5;//每次删除增加几个点 
        public static Queue<double> dataNitrite = new Queue<double>(60);

        private Panel leftBorderBtn;
        private IconButton currentBtn;

        private 实验配置 FrmConfigure;
        private 标定 FrmCalibration;
        private 样品测定 FrmSample;
        private 数据处理 FrmDataProcessing;
        private 实验测试 FrmExperimentalTest;
        private 注射泵测试 FrmPumpTest;
        private 附加工具 FrmAdditionalTool;
        private 设置 FrmBtnSetUp;
        #endregion

        #region 窗体构造函数
        public FrmMain()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            CreatAllForm();//创建所有窗体
        }
        #endregion

        #region 窗体加载
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region 菜单
        private struct RGBColors
        {
            public static Color colors1 = Color.FromArgb(172, 126, 141);
            public static Color colors2 = Color.FromArgb(249, 118, 176);
            public static Color colors3 = Color.FromArgb(253, 138, 114);
            public static Color colors4 = Color.FromArgb(95, 77, 221);
            public static Color colors5 = Color.FromArgb(249, 88, 155);
            public static Color colors6 = Color.FromArgb(24, 161, 251);
        }

        public void ShowCurreForm(Form childForm)
        {
            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labTitleChildForm.Text = childForm.Text;
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DissableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(62, 157, 205);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = currentBtn.IconColor;
            }
        }

        private void DissableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(1, 171, 230);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void CreatAllForm()
        {
            FrmConfigure = new 实验配置(serialPort1);
            FrmConfigure.TopLevel = false;
            FrmConfigure.FormBorderStyle = FormBorderStyle.None;
            FrmConfigure.Dock = DockStyle.Fill;

            FrmCalibration = new 标定(serialPort1);
            FrmCalibration.TopLevel = false;
            FrmCalibration.FormBorderStyle = FormBorderStyle.None;
            FrmCalibration.Dock = DockStyle.Fill;

            FrmSample = new 样品测定(serialPort1);
            FrmSample.TopLevel = false;
            FrmSample.FormBorderStyle = FormBorderStyle.None;
            FrmSample.Dock = DockStyle.Fill;

            FrmDataProcessing = new 数据处理();
            FrmDataProcessing.TopLevel = false;
            FrmDataProcessing.FormBorderStyle = FormBorderStyle.None;
            FrmDataProcessing.Dock = DockStyle.Fill;

            FrmExperimentalTest = new 实验测试(serialPort1);
            FrmExperimentalTest.TopLevel = false;
            FrmExperimentalTest.FormBorderStyle = FormBorderStyle.None;
            FrmExperimentalTest.Dock = DockStyle.Fill;

            FrmPumpTest = new 注射泵测试(serialPort1);
            FrmPumpTest.TopLevel = false;
            FrmPumpTest.FormBorderStyle = FormBorderStyle.None;
            FrmPumpTest.Dock = DockStyle.Fill;

            FrmAdditionalTool = new 附加工具();
            FrmAdditionalTool.TopLevel = false;
            FrmAdditionalTool.FormBorderStyle = FormBorderStyle.None;
            FrmAdditionalTool.Dock = DockStyle.Fill;

            FrmBtnSetUp = new 设置();
            FrmBtnSetUp.TopLevel = false;
            FrmBtnSetUp.FormBorderStyle = FormBorderStyle.None;
            FrmBtnSetUp.Dock = DockStyle.Fill;
        }


        private void Reset()
        {
            DissableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home; ;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            labTitleChildForm.Text = "Home";
            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(pictureBox1);
            panelDesktop.Tag = pictureBox1;
            pictureBox1.BringToFront();
            pictureBox1.Show();
        }
        #endregion

        #region 主页
        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
        }
        #endregion

        #region 实验配置
        //打开子窗口
        private void iconBtnConfigure_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colors1);

            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(FrmConfigure);
            panelDesktop.Tag = FrmConfigure;
            FrmConfigure.BringToFront();
            FrmConfigure.Show();
            labTitleChildForm.Text = FrmConfigure.Text;
        }


        #endregion

        #region 标定
        private void iconBtnCalibration_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colors2);
            ShowCurreForm(FrmCalibration);
        }

        #endregion

        #region 样品测定
        private void iconBtnSample_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colors3);
            ShowCurreForm(FrmSample);
        }

        #endregion

        #region 数据处理
        private void iconBtnDataProcessing_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colors4);
            ShowCurreForm(FrmDataProcessing);
        }

        #endregion

        #region 实验测试
        private void iconBtnExperimentalTest_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colors2);
            ShowCurreForm(FrmExperimentalTest);
        }
        #endregion

        #region 注射泵测试
        private void iconBtnPumpTest_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colors5);
            ShowCurreForm(FrmPumpTest);
        }
        #endregion

        #region 附加工具
        private void iconBtnAdditionalTool_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colors6);
            ShowCurreForm(FrmAdditionalTool);
        }
        #endregion

        #region 设置
        private void iconBtnSetUp_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colors1);
            ShowCurreForm(FrmBtnSetUp);
        }
        #endregion

        #region 时钟
        private void dateTime_Tick(object sender, EventArgs e)
        {
            labTime.Text = DateTime.Now.ToString("yyyy-MM-dd    HH:mm:ss");
        }
        #endregion

        #region 数据接收
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int bufLength = serialPort1.BytesToRead;
                byte[] receivedBuf = new byte[bufLength];//定义一个接收数组，获取接收缓冲区数据的字节数
                serialPort1.Read(receivedBuf, 0, bufLength);//读取数据
                if (receivedBuf[0] != 0x81 || receivedBuf[1] != bufLength || receivedBuf[2] != 0x21 || receivedBuf[9] != 0x82)
                {
                    serialPort1.DiscardInBuffer();//清除串口缓冲区
                    Array.Clear(receivedBuf, 0, bufLength);
                    return;
                }
                ReceiveData(receivedBuf);
            }
            catch (Exception)
            {
                //MessageBox.Show("接收数据出现错误:" + ex.Message);
                return;
            }
        }
        private void ReceiveData(byte[] receivedBuf)
        {
            byte sum = 0;
            for (int i = 0; i < receivedBuf.Length - 2; i++)
            {
                sum += receivedBuf[i];
            }
            if (receivedBuf[8] == sum)
            {
                if (receivedBuf[3] == 0x0a)
                {
                    string Voltage1_H = receivedBuf[4].ToString();
                    string Voltage1_L = receivedBuf[5].ToString();
                    double Voltage1 = (float.Parse(Voltage1_H) * 256 + float.Parse(Voltage1_L)) * 2.5 / 65536;
                    double Voltage = Convert.ToDouble(Voltage1.ToString().Substring(0, 7));
                    DataProcessing.currentValue1 = Voltage;
                    DataAcquisition(Voltage);
                }
                else return;
            }
            else return;
        }
        private void DataAcquisition(double curData)
        {
            if (dataNitrite.Count > 30)
            {
                for (int i = 0; i < num; i++)//先出列
                {
                    dataNitrite.Dequeue();
                }
            }
            for (int i = 0; i < num; i++)
            {
                dataNitrite.Enqueue(curData);
                //dataCurValue = dataCurValue + 5;
            }
        }


        #endregion       
    }
}
