using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADovhanych_Task4
{
    class PhoneLogger : ILogger
    {
        public void LogInfo(string message)
        {
            Console.WriteLine(message);
        }
    }
}
