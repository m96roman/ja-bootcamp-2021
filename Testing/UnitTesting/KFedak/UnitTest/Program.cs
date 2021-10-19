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
            phoneTest.RunLogger(KFedak_Task9.Program.CreatePhones());
            phoneTest.RunTest();

            Console.WriteLine("\n\nNokia\n\n");

            NokiaTest nokiaTest = new((FakeLogger)fakelogger);
            nokiaTest.RunLogger(KFedak_Task9.Program.CreatePhones());
            nokiaTest.RunTest();
        }
    }
}

