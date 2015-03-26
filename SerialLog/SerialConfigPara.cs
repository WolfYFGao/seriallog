using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Diagnostics;

namespace SerialLog
{
    public class SerialConfigPara
    {
        public string PortName = "";
        public int BaudRate = 9600;
        public int DataBits = 8;
        public Parity Parity = Parity.None;
        public StopBits StopBits = StopBits.One;

        public SerialConfigPara(string name)
        {
            if (name == null)
            {
                name = "";
            }
        }

        public void Print()
        {
            Debug.WriteLine("串口：{0}  波特率：{1}", this.PortName, this.BaudRate);
        }
    }
}
