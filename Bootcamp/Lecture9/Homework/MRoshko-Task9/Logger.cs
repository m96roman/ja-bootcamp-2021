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

            var logMassege = $@"{DateTime.UtcNow} - {log}";

            if (File.Exists(Path.GetFileName(path)))
            {
                using (StreamWriter fa = File.AppendText(path))
                {
                    fa.WriteLine(logMassege);
                }
            }
            else
            {
                using (FileStream fs = File.Create(path))
                {
                    var text = Encoding.Default.GetBytes(logMassege);

                    fs.Write(text, 0, text.Length);
                }
            }

            Console.WriteLine($@"{DateTime.UtcNow} - {log}");
        }
    }


}
