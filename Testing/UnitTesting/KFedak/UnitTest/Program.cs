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

            Console.WriteLine("*************NOKIA****************");
            
            RunTestNokia((FakeLogger)fakelogger);
            
            Console.WriteLine("*************IPHONE****************");

            RunTestIPhone((FakeLogger)fakelogger);
        }

        public static void RunTestNokia(FakeLogger fakeLogger)
        {
            NokiaTest testPhone = new NokiaTest(fakeLogger);

            testPhone.ValidBatteryLevelCheckException(-5, "10");

            testPhone.ValidBatteryLevelCheckException(5, "10");

            testPhone.ValidBatteryLevelCheckValue(5, "10");

            testPhone.ValidBatteryLevelCheckValue(-5, "10");

            var phoneAmmbulance = new List<Phone>
            {
                new Nokia(4, "546",fakeLogger),
                new Nokia(25, "211",fakeLogger)
            };

            testPhone.CheckCallAmbulance(phoneAmmbulance);

            var phoneCharge = new List<Phone>
            {
                new Nokia(40, "567",fakeLogger),
                new Nokia(25, "123",fakeLogger)
            };

            testPhone.CheckCharge(phoneCharge);

            var phoneChargeABit = new List<Phone>
            {
                new Nokia(4, "78",fakeLogger),
                new Nokia(25, "8400",fakeLogger)
            };

            testPhone.CheckChargeABit(phoneChargeABit);

            var phonePrayForBattery = new List<Phone>
            {
                new Nokia(4, "Nokia",fakeLogger),
            };

            testPhone.CheckPrayForBattery(phonePrayForBattery);

            testPhone.CheckCallAmbulanceLogged(phoneAmmbulance);

            testPhone.ValidBatteryLevelCheckExceptionLogged();

            testPhone.CheckChargeLogged(phoneCharge);

            testPhone.CheckChargeABitLogged(phoneChargeABit);

            testPhone.CheckPrayForBatteryLogged(phonePrayForBattery);
        }

        public static void RunTestIPhone(FakeLogger fakeLogger)
        {
            TestPhone testPhone = new IPhoneTest(fakeLogger);

            testPhone.ValidBatteryLevelCheckException(-5, "10");

            testPhone.ValidBatteryLevelCheckException(5, "10");

            testPhone.ValidBatteryLevelCheckValue(5, "10");

            testPhone.ValidBatteryLevelCheckValue(-5, "10");

            var phoneAmmbulance = new List<Phone>
            {
                new IPhone(4, "IPhone12",fakeLogger),
                new IPhone(25, "IPhone13",fakeLogger)
            };

            testPhone.CheckCallAmbulance(phoneAmmbulance);

            var phoneCharge = new List<Phone>
            {
                new IPhone(40, "IPhone7",fakeLogger),
                new IPhone(25, "IPhone10",fakeLogger)
            };

            testPhone.CheckCharge(phoneCharge);

            var phoneChargeABit = new List<Phone>
            {
                new IPhone(4, "IPhone13",fakeLogger),
                new IPhone(25, "IPhone8",fakeLogger)
            };

            testPhone.CheckChargeABit(phoneChargeABit);

            testPhone.CheckCallAmbulanceLogged(phoneAmmbulance);

            testPhone.ValidBatteryLevelCheckExceptionLogged();

            testPhone.CheckChargeLogged(phoneCharge);

            testPhone.CheckChargeABitLogged(phoneChargeABit);
        }
    }
}

