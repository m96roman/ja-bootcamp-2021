using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting_Martin_Task1
{
    class ConsoleLogger
    {
        private int TestNumb { get; set; }
        protected static int TestCount { get; set; }

        protected string Log { get; set; }

        private bool Status { get; set; }

        public ConsoleLogger(bool stateOfTest, string log = null)
        {
            TestCount += 1;
            TestNumb = TestCount;
            Log = log;
            Status = stateOfTest;
        }

        public void WriteTestResult()
        {
            Console.WriteLine("---------------------------------------------------");
            if (Status)
            {
                Passed(Log);
            }
            else
            {
                Fail(Log);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------------------------------------------");
        }
        private void Passed(string log)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{TestNumb}) Test is Passed");
            Console.WriteLine(log);
        }
        private void Fail(string log)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{TestNumb})Test is Fail");
            Console.WriteLine(log);
        }
    }
}
