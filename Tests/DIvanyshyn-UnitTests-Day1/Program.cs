using System;
using DIVanyshyn_Task4;

namespace DIvanyshyn_UnitTests_Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            ITestable nokiaTest = new NokiaTests(WriteResult);
            ITestable phoneTests1 = new UniversalPhoneTests(WriteResult, typeof(Nokia));
            ITestable phoneTests2 = new UniversalPhoneTests(WriteResult, typeof(IPhone13));
            ITestable emeregencyHolder = new PhoneEmeregencyHolderTests(WriteResult);
            ITestable programTests = new ProgramPhonesTests(WriteResult);

            Console.WriteLine(new string('~', 20));

            nokiaTest.RunAll();

            Console.WriteLine(new string('~', 20));

            phoneTests1.RunAll();

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
    }
}
