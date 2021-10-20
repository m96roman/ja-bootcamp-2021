using System;

namespace UnitTestsPhonesApp
{
    class Logger
    {
        public static void PassedTest(int info)
        {
            Console.WriteLine($"Test was PASSED with battery level: {info}");
        }
        public static void FailedTest(int info)
        {
            Console.WriteLine($"Test was Failed with battery level: {info}");
        }

    }
}
