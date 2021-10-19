using System;
using System.Collections.Generic;
using System.Diagnostics;
using KFedak_Task9;
using KFedak_UnitTest1;
using NUnit.Framework;

namespace UnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger fakelogger = new FakeLogger();
            KFedak_Task9.Program.logger = fakelogger;
            KFedak_Task9.Program.Main();

            Console.WriteLine("\n\nIPhone\n\n");

            IPhoneTest phoneTest = new((FakeLogger)fakelogger);

            Console.WriteLine("LoggerTest\n\n");

            phoneTest.RunLogger(KFedak_Task9.Program.phones);

            Console.WriteLine("\nTest\n");

            phoneTest.RunTest();

            Console.WriteLine("\n\nNokia\n\n");

            NokiaTest nokiaTest = new((FakeLogger)fakelogger);

            Console.WriteLine("LoggerTest\n\n");

            nokiaTest.RunLogger(KFedak_Task9.Program.phones);
            
            Console.WriteLine("\nTest\n");

            nokiaTest.RunTest();
        }
    }
}

