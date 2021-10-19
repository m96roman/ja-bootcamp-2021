using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsPhonesApp
{
    class Logger
    {
        public static void PassedTest()
        {
            Console.WriteLine("Test was PASSED");
        }
        public static void FailedTest()
        {
            Console.WriteLine("Test was Failed");
        }

    }
}
