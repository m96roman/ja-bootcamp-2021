using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPlyskaLect9
{
    public class Logger
    {
        public static void WriteLine(string messege)
        {
            File.AppendAllText("log.txt", DateTime.UtcNow + messege);
        }
             
    }
}
