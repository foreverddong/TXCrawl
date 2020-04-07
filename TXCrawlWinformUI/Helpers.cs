using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TXCrawl;

namespace TXCrawlWinformUI
{
    public class LogHelper
    {
        static StreamWriter w = File.AppendText("log.txt");
        public static MainForm logForm = null;
        public static void Log(LogType type, string data)
        {
            string logstr = $"[{type.ToString()}]  " + DateTime.Now.ToString() + "  " + data + "\r\n";
            logForm.logTextBox.Invoke((MethodInvoker)delegate {logForm.logTextBox.Text = logForm.logTextBox.Text + logstr; });
            w.WriteLine(logstr);
        }
    }

    public enum LogType
    {
        NOTICE,
        WARNING,
        ERROR
    }

}
