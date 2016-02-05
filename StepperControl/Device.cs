using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StepperControl
{
    public partial class Device : Form
    {
        public Device()
        {
            InitializeComponent();
        }

        private void Device_Load(object sender, EventArgs e)
        {
            //            string[] ArrayComPortsNames = null;
            string[] ArrayComPortsNames = DevInfo.DeviceInfo.ParseFriendlyPorts();
            int index = -1;
            string ComPortName = null;

            //ArrayComPortsNames = SerialPort.GetPortNames();
            ArrayComPortsNames = DevInfo.DeviceInfo.ParseFriendlyPorts();
            do
            {
                index += 1;
                DeviceBox.Text += ArrayComPortsNames[index] + "\n";
            }
            while (!((ArrayComPortsNames[index] == ComPortName) ||
                                (index == ArrayComPortsNames.GetUpperBound(0))));
        }
    }
}
