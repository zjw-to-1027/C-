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
    public partial class 注射泵测试 : Form
    {
        public SerialPort _pumpSerialPort;
        public 注射泵测试(SerialPort serialPort)
        {
            this._pumpSerialPort = serialPort;
            InitializeComponent();
        }
        #region 将泵测试相关命令发送出去
        private void btnPumpSent_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_pumpSerialPort.IsOpen)
                {
                    MessageBox.Show("请打开串口", "端口未打开");
                }
                CmdEntity textCmd = new CmdEntity();
                byte[] byteArray = textCmd.GetSentArray(txtCmd.Text.Trim(), 0x31);
                for (int i = 0; i < 5; i++)
                {
                    _pumpSerialPort.Write(byteArray, 0, byteArray.Length);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "详细信息");
            }
        }
        #endregion
    }
}
