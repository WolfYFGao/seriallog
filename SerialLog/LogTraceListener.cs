using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace SerialLog
{
    public class LogTraceListener : TraceListener
    {
        public override void Write(string message)
        {
            File.AppendAllText("log.txt", message);
        }

        public override void WriteLine(string message)
        {
            File.AppendAllText("log.txt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss    ") + message + Environment.NewLine);
        }
    }
}
