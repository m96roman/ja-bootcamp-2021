using System;
using DIVanyshyn_Task4;

namespace DIvanyshyn_UnitTests_Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            ITestable nokiaTest = new NokiaTests(LogSuccess, LogFailure);
            ITestable phoneTests1 = new UniversalPhoneTests(LogSuccess, LogFailure, typeof(Nokia));
            ITestable phoneTests2 = new UniversalPhoneTests(LogSuccess, LogFailure, typeof(IPhone13));
            ITestable emeregencyHolder = new PhoneEmeregencyHolderTests(LogSuccess, LogFailure);
            ITestable programTests = new ProgramPhonesTests(LogSuccess, LogFailure);

            Console.WriteLine(new string('~', 20));

            nokiaTest.RunAll();

            Console.WriteLine(new string('~', 20));

            phoneTests1.RunAll();

            Console.WriteLine(new string('~', 20));

            phoneTests2.RunAll();

            Console.WriteLine(new string('~', 20));

            emeregencyHolder.RunAll();

            Console.WriteLine(new string('~', 20));

            programTests.RunAll();

            Console.WriteLine(new string('~', 20));

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

        private static void LogFailure(string methodName)
        {
            WriteResult(methodName + " failed", ConsoleColor.Red);
        }

        private static void LogSuccess(string methodName)
        {
            WriteResult(methodName + " successed", ConsoleColor.Green);
        }
    }
}
