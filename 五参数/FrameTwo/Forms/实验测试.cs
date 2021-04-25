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

namespace FrameTwo.Forms
{
    public partial class 实验测试 : Form
    {
        #region 全局变量、字段、属性
        int time;//存储设定的定时值
        int count;//用于定时器计数
        byte getAFlag = 0;//接收A路光强标志位
        public SerialPort _expSerialPort;      
        #endregion

        #region 窗体构造函数
        public 实验测试(SerialPort serialPort)
        {
            this._expSerialPort = serialPort;
            InitializeComponent();
        }
        #endregion

        #region 窗体加载
        private void 实验测试_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            for (int i = 0; i < 10; i++)
            {
                dgvTesting.Rows.Add();
            }
        }
        #endregion

        #region 测试内容发生改变时
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        #endregion

        #region 泵初始化
        private void btnInit_Click(object sender, EventArgs e)
        {
            if (!_expSerialPort.IsOpen)
            {
                MessageBox.Show("请打开串口", "端口未打开");
                return;
            }
            CmdEntity pumpInitCmd = new CmdEntity();
            byte[] byteArray = pumpInitCmd.GetSentArray("ZR", 0x31);
            for (int i = 0; i < 5; i++)
            {
                _expSerialPort.Write(byteArray, 0, byteArray.Length);
            }
        }
        #endregion

        #region 清洗
        private void btnWash_Click(object sender, EventArgs e)
        {
            if (!_expSerialPort.IsOpen)
            {
                MessageBox.Show("请打开串口", "端口未打开");
                return;
            }
            panel2.Visible = true;
            CmdEntity textCmd = new CmdEntity();
            CmdNitrite cmdNitrite = new CmdNitrite();
            string strWash = cmdNitrite.GetCmdWash();
            byte[] byteArray = textCmd.GetSentArray(strWash.Trim(), 0x31);
            for (int i = 0; i < 10; i++)
            {
                _expSerialPort.Write(byteArray, 0, byteArray.Length);
            }
            Progress(130, "清洗");//延时13秒，进度条提示当前清洗进度
            panel2.Visible = false;
        }
        #endregion

        #region 开始实验
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (PortVariable.PortPureWater == null)
            {
                MessageBox.Show("请完成泵端口配置，并更新！", "泵端口配置未完成");
                return;
            }
            if (!_expSerialPort.IsOpen)
            {
                MessageBox.Show("请打开串口", "端口未打开");
                return;
            }
            getAFlag = 1;
            if (TestObject._currentNutrients == "亚硝酸盐")
            {
                panel2.Visible = true;
                CmdEntity testCmd = new CmdEntity();
                CmdNitrite cmdNitrite = new CmdNitrite();
                string strWash = cmdNitrite.GetCmdWash();
                string strTesting = cmdNitrite.Testing();
                byte[] byteArray = testCmd.GetSentArray(strTesting.Trim(), 0x31);
                dgvTesting.Rows.Clear();//清除dgvCalibration内的所有单元格
                StandSolution.TestStandSol = Convert.ToInt32(cbmNumber.Text);
                for (int i = 0; i < Convert.ToInt32(cbmNumber.Text); i++)
                {
                    byte[] byteArray1 = testCmd.GetSentArray(strWash.Trim(), 0x31);
                    for (int j = 0; j < 10; j++)
                    {
                        _expSerialPort.Write(byteArray1, 0, byteArray1.Length);
                    }
                    panel2.Visible = true;
                    dgvTesting.CurrentCell = dgvTesting.Rows[i].Cells[0];
                    dgvTesting.Rows[i].Cells[0].Value = (i + 1).ToString();

                    Progress(130, "测试溶液" + (i + 1).ToString() + "，清洗");//延时13秒，进度条提示当前清洗进度
                    Progress(50, "等待流通池稳定");//延时5秒，等待流通池稳定
                    Progress(50, "测试溶液" + (i + 1).ToString() + "空白值");//延时5秒，等待流通池稳定
                    for (int j = 0; j < 10; j++)
                    {
                        _expSerialPort.Write(byteArray, 0, byteArray.Length);
                    }
                    Progress(130, "清洗");//延时13秒，进度条提示当前清洗进度



                    panel2.Visible = false;
                }

            }
        }
        #endregion

        #region 进度条
        private void taskTimer_Tick(object sender, EventArgs e)
        {
            count++;//记当前秒
            progressBar1.Value = count;//设置进度条进度
            if (count == time)
            {
                taskTimer.Stop();//时间到，停止计时
            }
        }
        private void Progress(int times, string message)
        {
            count = 0;
            time = times;
            progressBar1.Maximum = times;
            labCurrentTask.Text = message;
            taskTimer.Start();
            do
            {
                Application.DoEvents();
            }
            while (count < time);
        }
        #endregion

        #region 更新显示光强值
        private void showValueTimer_Tick(object sender, EventArgs e)
        {
            if (getAFlag == 1)
            {
                label7.Text = DataProcessing.currentValue1.ToString() + "V";
            }
            else if (getAFlag == 0)
            {
                label7.Text = "null";
            }
        }
        #endregion
    }
}
