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
    public partial class 标定 : Form
    {
        #region 窗体全局变量、字段、属性
        int time;//存储设定的定时值
        int count;//用于定时器计数
        byte getAFlag = 0;//接收A路光强标志位
        public SerialPort _calSerialPort;
        #endregion

        #region 窗体构造函数
        public 标定(SerialPort serialPort)
        {
            this._calSerialPort = serialPort;
            InitializeComponent();
        }
        #endregion

        #region 数据发送
        //向下位机发送获取A路光强指令
        private void btnGetA_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_calSerialPort.IsOpen)
                {
                    MessageBox.Show("请打开串口", "端口未打开");
                    return;
                }
                getAFlag = 1;
                CmdGetvalueOfTankA cmdGetvalueOfTankA = new CmdGetvalueOfTankA();
                byte[] byteArray = cmdGetvalueOfTankA.GetCmdArray();
                for (int i = 0; i < 5; i++)
                {
                    _calSerialPort.Write(byteArray, 0, 6);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "详细信息");
            }
        }
        //向下位机发送关闭A路光强指令
        private void btnCloseA_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_calSerialPort.IsOpen)
                {
                    MessageBox.Show("请打开串口", "端口未打开");
                    return;
                }
                getAFlag = 0;
                CmdClosevalueOfTankA cmdClosevalueOfTankA = new CmdClosevalueOfTankA();
                byte[] byteArray = cmdClosevalueOfTankA.GetCmdArray();
                for (int i = 0; i < 5; i++)
                {
                    _calSerialPort.Write(byteArray, 0, 6);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "详细信息");
            }
        }
        #endregion     

        #region 窗体加载
        private void 标定_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            for (int i = 0; i < 2; i++)
            {
                dgvResult.Rows.Add();
            }
            for (int i = 0; i < 4; i++)
            {
                dgvCalibration.Rows.Add();
            }
            
            dgvResult.CurrentCell = dgvResult.Rows[2].Cells[0];
            dgvResult.Font = new Font("宋体", 14, FontStyle.Regular);
            dgvCalibration.Font = new Font("宋体", 14, FontStyle.Regular);
            dgvResult.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCalibration.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvResult.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCalibration.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        #endregion

        #region 泵初始化
        private void btnInit_Click(object sender, EventArgs e)
        {
            if (!_calSerialPort.IsOpen)
            {
                MessageBox.Show("请打开串口", "端口未打开");
                return;
            }
            CmdEntity pumpInitCmd = new CmdEntity();
            byte[] byteArray = pumpInitCmd.GetSentArray("ZR", 0x31);
            for (int i = 0; i < 5; i++)
            {
                _calSerialPort.Write(byteArray, 0, byteArray.Length);
            }
        }
        #endregion

        #region 清洗
        private void btnWash_Click(object sender, EventArgs e)
        {
            if (!_calSerialPort.IsOpen)
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
                _calSerialPort.Write(byteArray, 0, byteArray.Length);
            }
            Progress(130, "清洗");//延时13秒，进度条提示当前清洗进度
            panel2.Visible = false;
        }
        #endregion

        #region 标定
        private void btnCalibration_Click(object sender, EventArgs e)
        {
            if (PortVariable.PortPureWater == null)
            {
                MessageBox.Show("请完成泵端口配置，并更新！", "泵端口配置未完成");
                return;
            }
            if (!_calSerialPort.IsOpen)
            {
                MessageBox.Show("请打开串口", "端口未打开");
                return;
            }

            #region 硝酸盐
            if (TestObject._currentNutrients == "硝酸盐")
            {
                CmdEntity CmdSent = new CmdEntity();
                CmdNitrate cmdNitrate = new CmdNitrate();
                string strWash = cmdNitrate.GetCmdWash();//获取硝酸盐清洗命令
                string[] strMixed = cmdNitrate.GetCmdMixed();//获取硝酸盐配液命令数组
                dgvCalibration.Rows.Clear();//清除dgvCalibration内的所有单元格
                for (int i = 0; i < 4; i++)
                {
                    dgvCalibration.Rows.Add();
                }
                for (int i = 0; i < StandSolution.StandNumber; i++)
                {
                    this.Focus();
                    double temp1 = 0;
                    double temp2 = 0;
                    byte[] washByteToSent = CmdSent.GetSentArray(strWash.Trim(), 0x31);
                    for (int j = 0; j < 10; j++)
                    {
                        _calSerialPort.Write(washByteToSent, 0, washByteToSent.Length);//向下位机发送清洗命令，重复发10次确保下位机能准确收到
                                                                                       //三次握手模式下发一次即可
                    }
                    panel2.Visible = true;//当前任务指示面板可见
                    dgvCalibration.CurrentCell = dgvCalibration.Rows[i].Cells[0];//把i行0列单元格设置为当前单元格
                    dgvCalibration.Rows[i].Cells[0].Value = (i + 1).ToString();
                    Progress(130, "标液" + (i + 1).ToString() + "，清洗");//延时13秒，进度条提示当前清洗进度
                    Progress(50, "等待流通池稳定");//延时5秒，等待流通池稳定
                    Progress(50, "取标液" + (i + 1).ToString() + "空白值");//延时5秒，等待流通池稳定
                    foreach (var item in FrmMain.dataNitrite)//遍历队列中成员，求和
                    {
                        temp1 += item;
                    }
                    NitriteExpData.LightIn[i] = temp1 / FrmMain.dataNitrite.Count;//队列取均值->入射光强
                    dgvCalibration.CurrentCell = dgvCalibration.Rows[i].Cells[1];//把i行1列单元格设置为当前单元格
                    dgvCalibration.Rows[i].Cells[1].Value = NitriteExpData.LightIn[i].ToString().Substring(0, 6);//i行1列单元格显示第i个入射光强值

                    byte[] mixedByteToSent = CmdSent.GetSentArray(strMixed[i].Trim(), 0x31);
                    for (int j = 0; j < 10; j++)
                    {
                        _calSerialPort.Write(mixedByteToSent, 0, mixedByteToSent.Length);//向下位机发送配液命令，重复发10次确保下位机能准确收到
                                                                                         //三次握手模式下发一次即可
                    }
                    Progress(40, "配第" + (i + 1).ToString() + "个标准溶液");//延时4秒，进度条提示当前配液进度
                    Progress(900, "在加热棒加热至70°");//延时90秒，混合液在加热棒中反应
                    Progress(250, "等待流通池显色反应稳定");//延时25秒，等待流通池显色反应稳定
                    Progress(50, "取标液" + (i + 1).ToString() + "透射光光强值");//延时5秒，等待流通池稳定
                    foreach (var item in FrmMain.dataNitrite)//遍历队列中成员，求和
                    {
                        temp2 += item;
                    }
                    NitriteExpData.LightOut[i] = temp2 / FrmMain.dataNitrite.Count;//队列取均值->透射光强
                    NitriteExpData.Absorbance[i] = Math.Log10(NitriteExpData.LightIn[i] / NitriteExpData.LightOut[i]);//计算吸光度
                    dgvCalibration.CurrentCell = dgvCalibration.Rows[i].Cells[2];//把i行2列单元格设置为当前单元格
                    dgvCalibration.Rows[i].Cells[2].Value = NitriteExpData.LightOut[i].ToString().Substring(0, 6);//i行2列单元格显示第i个透射光强值
                    dgvCalibration.CurrentCell = dgvCalibration.Rows[i].Cells[3];//把i行3列单元格设置为当前单元格
                    dgvCalibration.Rows[i].Cells[3].Value = NitriteExpData.Absorbance[i].ToString().Substring(0, 6);//i行3列单元格显示第i个吸光值
                    panel2.Visible = false;//当前任务指示面板不可见
                }
            }
            #endregion

            #region 亚硝酸盐
            if (TestObject._currentNutrients == "亚硝酸盐")
            {
                CmdEntity textCmd = new CmdEntity();
                CmdNitrite cmdNitrite = new CmdNitrite();
                string strWash = cmdNitrite.GetCmdWash();
                string[] cmdArray = cmdNitrite.GetCmdMixed();
                dgvCalibration.Rows.Clear();//清除dgvCalibration内的所有单元格
                for (int i = 0; i < 4; i++)
                {
                    dgvCalibration.Rows.Add();
                }
                for (int i = 0; i < StandSolution.StandNumber; i++)
                {
                    this.Focus();
                    double temp1 = 0;
                    double temp2 = 0;
                    byte[] byteArray1 = textCmd.GetSentArray(strWash.Trim(), 0x31);
                    for (int j = 0; j < 10; j++)
                    {
                        _calSerialPort.Write(byteArray1, 0, byteArray1.Length);
                    }
                    panel2.Visible = true;
                    dgvCalibration.CurrentCell = dgvCalibration.Rows[i].Cells[0];
                    dgvCalibration.Rows[i].Cells[0].Value = (i + 1).ToString();

                    Progress(130, "标液" + (i + 1).ToString() + "，清洗");//延时13秒，进度条提示当前清洗进度
                    Progress(50, "等待流通池稳定");//延时5秒，等待流通池稳定
                    Progress(50, "取标液" + (i + 1).ToString() + "空白值");//延时5秒，等待流通池稳定
                    foreach (var item in FrmMain.dataNitrite)
                    {
                        temp1 += item;
                    }
                    NitriteExpData.LightIn[i] = temp1 / FrmMain.dataNitrite.Count;
                    dgvCalibration.CurrentCell = dgvCalibration.Rows[i].Cells[1];
                    dgvCalibration.Rows[i].Cells[1].Value = NitriteExpData.LightIn[i].ToString().Substring(0, 6);

                    byte[] byteArray2 = textCmd.GetSentArray(cmdArray[i].Trim(), 0x31);
                    for (int j = 0; j < 10; j++)
                    {
                        _calSerialPort.Write(byteArray2, 0, byteArray2.Length);
                    }
                    Progress(40, "配第" + (i + 1).ToString() + "个标准溶液");//延时4秒，进度条提示当前配液进度
                    Progress(100, "混合液在柱塞中反应");//延时15秒，混合液在柱塞中反应
                    Progress(200, "等待流通池显色反应稳定");//延时15秒，等待流通池显色反应稳定
                    Progress(50, "取标液" + (i + 1).ToString() + "透射光光强值");//延时5秒，等待流通池稳定
                    foreach (var item in FrmMain.dataNitrite)
                    {
                        temp2 += item;
                    }
                    NitriteExpData.LightOut[i] = temp2 / FrmMain.dataNitrite.Count;
                    NitriteExpData.Absorbance[i] = Math.Log10(NitriteExpData.LightIn[i] / NitriteExpData.LightOut[i]);
                    dgvCalibration.CurrentCell = dgvCalibration.Rows[i].Cells[2];
                    dgvCalibration.Rows[i].Cells[2].Value = NitriteExpData.LightOut[i].ToString().Substring(0, 6);
                    dgvCalibration.CurrentCell = dgvCalibration.Rows[i].Cells[3];
                    dgvCalibration.Rows[i].Cells[3].Value = NitriteExpData.Absorbance[i].ToString().Substring(0, 6);
                    panel2.Visible = false;
                }
            }
            #endregion

            #region 氨氮
            if (TestObject._currentNutrients == "氨氮")
            {

            }
            #endregion

            #region 磷酸盐
            if (TestObject._currentNutrients == "磷酸盐")
            {

            }
            #endregion#region 磷酸盐

            #region 硅酸盐
            if (TestObject._currentNutrients == "硅酸盐")
            {

            }
            #endregion#region 磷酸盐

            Calculation();
        }
        #endregion

        #region 标定后计算
        private void Calculation()
        {
            double r = 0;//相关系数
            int[] xnum = new int[StandSolution.StandNumber];
            double[] ynum = new double[StandSolution.StandNumber];
            for (int i = 0; i < StandSolution.StandNumber; i++)
            {
                xnum[i] = (int)CmdNitrite.solutionArray2[i];
            }
            for (int i = 0; i < StandSolution.StandNumber; i++)
            {
                ynum[i] = NitriteExpData.Absorbance[i];
            }
            double xsum = 0;//x值求和
            double ysum = 0;//y值求和
            for (int i = 0; i < xnum.Length; i++)
            {
                xsum += Convert.ToDouble(xnum[i]);
                ysum += Convert.ToDouble(ynum[i]);
            }
            double xAve = Convert.ToDouble(xsum / xnum.Length);//x平均值
            double yAve = Convert.ToDouble(ysum / xnum.Length);//y平均值

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

            r = (molecule / Denominator) * Math.Sqrt(rMolecule / rDenominator);
            dgvResult.Rows[0].Cells[0].Value = "r:" + r.ToString();
            dgvResult.Rows[1].Cells[0].Value = "R2:" + (r * r).ToString();

            if ((yAve - (molecule / Denominator) * xAve) < 0)
            {
                dgvResult.Rows[2].Cells[0].Value= "回归方程:" + "y=" + (molecule / Denominator).ToString("f3") + "X" + (yAve - (molecule / Denominator) * xAve).ToString("f3");
            }
            else
            {
                dgvResult.Rows[2].Cells[0].Value = "回归方程:" + "y=" + (molecule / Denominator).ToString("f3") + "X+" + (yAve - (molecule / Denominator) * xAve).ToString("f3");
            }
        }
            #endregion

        #region 延时函数
        public static void Delay(int milliSecond)
        {
            int start = Environment.TickCount;
            while (Math.Abs(Environment.TickCount - start) < milliSecond)
            {
                Application.DoEvents();
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
