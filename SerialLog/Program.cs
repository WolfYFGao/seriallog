using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace SerialLog
{
   public static class Program
    {
        public static SerialConfigPara serialPortPara;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            serialPortPara = new SerialConfigPara(null);
            Trace.Listeners.Add(new LogTraceListener()); //添加MyTraceListener实例
            Application.Run(new FrmSerialPort());
        }
    }
}
