using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRoshko_Task9
{
    class Logger
    {
        public Logger()
        {
        }

        public void WriteLine(string log)
        {
            var path = $@"{Directory.GetCurrentDirectory()}\CallLog.txt";

            var logMessage = $"\n{DateTime.UtcNow} - {log}";

            File.AppendAllText(path, logMessage);                      
        }
    }
}
