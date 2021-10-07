using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedak_Task9
{
    public class Logger
    {
        public static void WriteLine(string message)
        {
            string logFilePath = Path.Combine(Directory.GetCurrentDirectory(), "log.txt");
            StringBuilder sb = new();
            sb.Append($"\n{message}");
            File.AppendAllText(logFilePath, sb.ToString());
            sb.Clear();
        }
    }
}
