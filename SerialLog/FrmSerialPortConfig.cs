using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;

namespace SerialLog
{
    public partial class FrmSerialPortConfig : Form
    {
        public FrmSerialPortConfig()
        {
            InitializeComponent();
        }


        private void SerialPortConfig_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            cmbPortName.Items.AddRange(ports);
        }


        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            Program.serialPortPara.PortName = this.cmbPortName.SelectedValue as string;
            Debug.WriteLine(this.cmbBaudRate.SelectedItem.ToString());
            Program.serialPortPara.BaudRate = int.Parse(this.cmbBaudRate.SelectedItem.ToString());
            Program.serialPortPara.Print();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
