using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADovhanych_Task9._4
{
    class Logger
    {
        public void WriteLine(string exception)
        {
            string directory = Directory.GetCurrentDirectory();

            using StreamWriter streamWriter = File.AppendText($@"{directory}\logs.txt");
            streamWriter.WriteLine($"{DateTime.Now} - {exception}");
        }
    }
}
