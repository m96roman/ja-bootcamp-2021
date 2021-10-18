using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsPhonesApp
{
    class Logger
    {
        void PassedTest()
        {
            Console.WriteLine("Test was PASSED");
        }
        public void FailedTet()
        {
            Console.WriteLine("Test was Failed");
        }

    }
}
