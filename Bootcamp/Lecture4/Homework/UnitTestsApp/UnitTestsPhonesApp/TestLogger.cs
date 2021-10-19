using ADovhanych_Task4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsPhonesApp
{
    class TestLogger : ILogger
    {
        public List<string> Messages { get; set; } = new List<string>();

        public void LogInfo(string message)
        {
            Messages.Add(message);
        }
    }
}
