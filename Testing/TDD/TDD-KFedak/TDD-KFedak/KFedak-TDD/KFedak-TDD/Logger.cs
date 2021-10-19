using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedak_TDD
{
    public class Logger : ILogger
    {
        public void WriteLine(Exception e)
        {
            string logFilePath = Path.Combine(Directory.GetCurrentDirectory(), "log.txt");
            File.AppendAllText(logFilePath, e.ToString());
        }
    }
}
