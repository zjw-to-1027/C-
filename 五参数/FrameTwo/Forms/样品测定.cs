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
    public partial class 样品测定 : Form
    {
        public SerialPort _deterSetSerialPort;
        public 样品测定(SerialPort serialPort)
        {
            this._deterSetSerialPort = serialPort;
            InitializeComponent();
        }
    }
}
