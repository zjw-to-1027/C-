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
    public partial class 实验配置 : Form
    {
        public SerialPort _setSerialPort;
        public 实验配置(SerialPort serialPort)
        {
            this._setSerialPort = serialPort;
            InitializeComponent();
        }

        #region 实验配置窗体加载
        private void 实验配置_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region 获取电脑当前可用串口并添加到选项列表中
        private void cmbPorts_Click(object sender, EventArgs e)
        {
            cmbPorts.Items.Clear();
            cmbPorts.Items.AddRange(SerialPort.GetPortNames());
        }
        #endregion

        #region 打开或关闭串口
        private void btnOpenOrClose_Click(object sender, EventArgs e)
        {
            try
            {
                //根据当前串口属性来判断是否打开
                if (_setSerialPort.IsOpen)
                {
                    _setSerialPort.Close();
                    btnOpenOrClose.Text = "打开串口";
                    btnOpenOrClose.BackColor = Color.ForestGreen;
                    cmbPorts.Enabled = true;
                    //cbmType.Enabled = true;
                }
                else
                {
                    //串口已经处于关闭状态，则设置好串口属性后打开
                    _setSerialPort.PortName = cmbPorts.Text.Trim();
                    _setSerialPort.Open();
                    btnOpenOrClose.Text = "关闭串口";
                    btnOpenOrClose.BackColor = Color.Firebrick;
                    cmbPorts.Enabled = false;
                    //cbmType.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                //捕获到异常，创建一个新的对象，之前的不可以再用
                _setSerialPort = new SerialPort();
                //刷新COM口选项
                cmbPorts.Items.Clear();
                cmbPorts.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
                //响铃并显示异常给用户
                System.Media.SystemSounds.Beep.Play();
                btnOpenOrClose.Text = "打开串口";
                btnOpenOrClose.BackColor = Color.ForestGreen;
                cmbPorts.Enabled = true;
                MessageBox.Show(ex.Message, "错误提示");
            }
        }

        #endregion

        #region 营养盐种类选择
        private void cbmType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmType.Text == "硝酸盐")
            {
                labHeater.Enabled = true;
                txtHeater.Enabled = true;
                labDye1.Text = "SAM:";
                labDye2.Text = "NED:";
                labDye3.Visible = true;
                txtDye3.Visible = true;
                labDye3.Text = "CCl3:";
                TestObject._currentNutrients = "硝酸盐";//设置当前检测营养盐为硝酸盐
            }
            else if (cbmType.Text == "亚硝酸盐")
            {
                labHeater.Enabled = false;
                txtHeater.Enabled = false;
                labDye1.Text = "SAM:";
                labDye2.Text = "NED:";
                labDye3.Visible = false;
                txtDye3.Visible = false;
                TestObject._currentNutrients = "亚硝酸盐";//设置当前检测营养盐为亚硝酸盐
            }
            else if (cbmType.Text == "氨氮")
            {
                labHeater.Enabled = true;
                txtHeater.Enabled = true;
                labDye1.Text = "邻苯基苯酚:";
                labDye2.Text = "二氯乙氰尿酸钠:";
                labDye3.Visible = true;
                txtDye3.Visible = true;
                labDye3.Text = "硝普钠:";
                TestObject._currentNutrients = "氨氮";//设置当前检测营养盐为氨氮
            }
            else if (cbmType.Text == "磷酸盐")
            {
                labHeater.Enabled = false;
                txtHeater.Enabled = false;
                labDye1.Text = "钼酸铵混合液:";
                labDye2.Text = "抗坏血酸:";
                labDye3.Visible = false;
                txtDye3.Visible = false;
                TestObject._currentNutrients = "磷酸盐";//设置当前检测营养盐为磷酸盐
            }
            else if (cbmType.Text == "硅酸盐")
            {
                labHeater.Enabled = false;
                txtHeater.Enabled = false;
                labDye1.Text = "钼酸盐:";
                labDye2.Text = "抗坏血酸:";
                labDye3.Visible = true;
                txtDye3.Visible = true;
                labDye3.Text = "草酸:";
                TestObject._currentNutrients = "硅酸盐";//设置当前检测营养盐为硅酸盐
            }
        }
        #endregion

        #region 重置
        private void btnReset_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;//“更新”buttom使能，可对用户交互响应
            cbmType.Enabled = true;//“下拉控件”cbmType使能，可对用户交互响应
            btnReset.Enabled = false;//“重置”buttom失能，对用户交互不作响应
            //清空静态属性中的端口数据
            PortVariable.PortSample = null;
            PortVariable.PortHeater = null;
            PortVariable.PortPureWater = null;
            PortVariable.PortWasteLiquid = null;
            PortVariable.PortReactionTank = null;
            PortVariable.PortDyeOne = null;
            PortVariable.PortDyeTwo = null;
            PortVariable.PortDyeThree = null;

            StandSolution.StandNumber = 0;
            StandSolution.StandSol1 = 0;
            StandSolution.StandSol2 = 0;
            StandSolution.StandSol3 = 0;
            StandSolution.StandSol4 = 0;
            StandSolution.StandSol5 = 0;

            cbmSolution.Enabled = true;
            standSol1.Enabled = true;
            standSol2.Enabled = true;
            standSol3.Enabled = true;
            standSol4.Enabled = true;
            standSol5.Enabled = true;

            txtSample.Enabled = true;
            txtPureWater.Enabled = true;
            txtWasteLiquid.Enabled = true;
            txtReactionTank.Enabled = true;
            txtDye1.Enabled = true;
            txtDye2.Enabled = true;
            if (cbmType.Text == "硝酸盐")
            {
                txtHeater.Enabled = true;
                txtDye3.Enabled = true;
            }
            else if (cbmType.Text == "亚硝酸盐") { }

            else if (cbmType.Text == "氨氮")
            {
                txtHeater.Enabled = true;
                txtDye3.Enabled = true;
            }
            else if (cbmType.Text == "磷酸盐") { }

            else if (cbmType.Text == "硅酸盐")
            {
                txtDye3.Enabled = true;
            }
        }
        #endregion

        #region 更新
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;//“更新”buttom失能，对用户交互不作响应
            cbmType.Enabled = false;//“下拉控件”cbmType失能，对用户交互不作响应
            btnReset.Enabled = true;//“重置”buttom使能，可对用户交互响应
            //加载最新端口编号
            PortVariable.PortSample = "I" + txtSample.Text.Trim();
            PortVariable.PortPureWater = "I" + txtPureWater.Text.Trim();
            PortVariable.PortWasteLiquid = "O" + txtWasteLiquid.Text.Trim();
            PortVariable.PortReactionTank = "O" + txtReactionTank.Text.Trim();
            PortVariable.PortDyeOne = "I" + txtDye1.Text.Trim();
            PortVariable.PortDyeTwo = "I" + txtDye2.Text.Trim();

            if (cbmSolution.Text == "")
            {
                MessageBox.Show("请选择标定液数量！", "标定溶液数量未确定");
                btnUpdate.Enabled = true;
                return;
            }
            StandSolution.StandNumber = Convert.ToInt32(cbmSolution.Text);
            StandSolution.StandSol1 = (int)standSol1.Value;
            StandSolution.StandSol2 = (int)standSol2.Value;
            StandSolution.StandSol3 = (int)standSol3.Value;
            StandSolution.StandSol4 = (int)standSol4.Value;
            StandSolution.StandSol5 = (int)standSol5.Value;

            cbmSolution.Enabled = false;
            standSol1.Enabled = false;
            standSol2.Enabled = false;
            standSol3.Enabled = false;
            standSol4.Enabled = false;
            standSol5.Enabled = false;

            txtSample.Enabled = false;
            txtPureWater.Enabled = false;
            txtWasteLiquid.Enabled = false;
            txtReactionTank.Enabled = false;
            txtDye1.Enabled = false;
            txtDye2.Enabled = false;
            if (cbmType.Text == "硝酸盐")
            {
                PortVariable.PortHeater = txtHeater.Text.Trim();
                PortVariable.PortDyeThree = "I" + txtDye3.Text.Trim();
                txtHeater.Enabled = false;
                txtDye3.Enabled = false;
            }
            else if (cbmType.Text == "亚硝酸盐") { }

            else if (cbmType.Text == "氨氮")
            {
                PortVariable.PortHeater = txtHeater.Text.Trim();
                PortVariable.PortDyeThree = "I" + txtDye3.Text.Trim();
                txtHeater.Enabled = false;
                txtDye3.Enabled = false;
            }

            else if (cbmType.Text == "磷酸盐") { }

            else if (cbmType.Text == "硅酸盐")
            {
                PortVariable.PortDyeThree = "I" + txtDye3.Text.Trim();
                txtDye3.Enabled = false;
            }
        }
        #endregion

        #region 查看
        private void btnCheck_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
