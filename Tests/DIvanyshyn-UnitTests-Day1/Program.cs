using System;
using DIVanyshyn_Task4;

namespace DIvanyshyn_UnitTests_Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            ITestable nokiaTest = new NokiaTests(WriteResult);

            ITestable iphoneTests = new IPhone13Tests(WriteResult);

            nokiaTest.RunAll();
            Console.WriteLine(new string('~', 20));
            iphoneTests.RunAll();
        }

        /// <summary>
        /// Helper method that writes result of test in console
        /// </summary>
        /// <param name="message">message to be printed</param>
        /// <param name="color">color indicator</param>
        private static void WriteResult(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
