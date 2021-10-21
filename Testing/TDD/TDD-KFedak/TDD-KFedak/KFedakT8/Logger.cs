using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedakT8
{
    public class Logger : ILogger
    {
        public void WriteLine(string message)
        {
            string logFilePath = Path.Combine(Directory.GetCurrentDirectory(), "log.txt");
            File.AppendAllText(logFilePath, message);
        }
    }
}
