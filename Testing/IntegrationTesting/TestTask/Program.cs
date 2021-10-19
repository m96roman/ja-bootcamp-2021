using System.Linq;
using Task;
using System;
using Task.Interfaces;
using TestTask.Interfaces;
using Task.Enums;
using Task.Exceptions;

namespace TestTask
{
    class Program
    {
        static IPhoneFactory phoneFactory = new PhoneFactory();

        static void Main(string[] args)
        {
            ChargeABitPhones();
            ChargPhones();
            PrayForBatteryPhones();
            TryCallAmbulanceIPhoneBatteryLess5();
            TryCallAmbulanceNokiaBatteryMore5();
            CreateInstancesBatteryLevel();
        }

        static void CreateInstancesBatteryLevel()
        {
            var logger = new FakeLogger();

            try
            {
                IPhone phoneIPhone13 = phoneFactory.CreatePhone(PhoneType.IPhone, "IPhone 13 Test 1", 102, logger);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                logger.LogMessage(ex.Message);
                TestResult(logger, "Battery range must be between 0 and 100");
            }

            try
            {
                IPhone phoneNokia = phoneFactory.CreatePhone(PhoneType.Nokia, "Nokia 3110 Test 2", -2, logger);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                logger.LogMessage(ex.Message);
                TestResult(logger, "Battery range must be between 0 and 100");
            }
        }

        static void TryCallAmbulanceNokiaBatteryMore5()
        {
            var logger = new FakeLogger();

            IPhone phoneIPhone13 = phoneFactory.CreatePhone(PhoneType.IPhone, "IPhone 13 Test 1", 14, logger);
            phoneIPhone13.CallAmbulance();

            IPhone phoneNokia = phoneFactory.CreatePhone(PhoneType.Nokia, "Nokia 3110 Test 2", 18, logger);
            phoneNokia.CallAmbulance();

            TestResult(logger, $"calling an ambulance from {phoneIPhone13.PhoneName}");
            TestResult(logger, $"calling an ambulance from {phoneNokia.PhoneName}");
        }

        static void TryCallAmbulanceIPhoneBatteryLess5()
        {
            var logger = new FakeLogger();

            IPhone phoneIPhone13 = phoneFactory.CreatePhone(PhoneType.IPhone, "IPhone 13 Test 1", 4, logger);
            try
            {
                phoneIPhone13.CallAmbulance();
            }
            catch(BatteryIsDeadException ex)
            {
                TestResult(logger, $"{ex.Phone.PhoneName} have died battery!");
            }

            IPhone phoneNokia = phoneFactory.CreatePhone(PhoneType.Nokia, "Nokia 3110 Test 2", 3, logger);
            try
            {
                phoneNokia.CallAmbulance();
            }
            catch(BatteryIsDeadException ex)
            {
                TestResult(logger, $"{ex.Phone.PhoneName} have died battery!");
            }
        }

        static void PrayForBatteryPhones()
        {
            var logger = new FakeLogger();

            Nokia phoneNokia = new Nokia("Nokia 3110 Test 2", 18, PhoneType.Nokia, logger);
            phoneNokia.PrayForBattery();

            TestResult(logger, $"praying for the battery {phoneNokia.PhoneName}");
        }

        static void ChargPhones()
        {
            var logger = new FakeLogger();

            IPhone phoneIPhone13 = phoneFactory.CreatePhone(PhoneType.IPhone, "IPhone 13 Test 1", 14, logger);
            phoneIPhone13.Charge();

            IPhone phoneNokia = phoneFactory.CreatePhone(PhoneType.Nokia, "Nokia 3110 Test 2", 18, logger);
            phoneNokia.Charge();

            TestResult(logger, $"Charging {phoneIPhone13.PhoneName} to 100%");
            TestResult(logger, $"Charging {phoneNokia.PhoneName} to 100%");
        }

        static void ChargeABitPhones()
        {
            var logger = new FakeLogger();

            IPhone phoneIPhone13 = phoneFactory.CreatePhone(PhoneType.IPhone, "IPhone 13 Test 1", 14, logger);
            phoneIPhone13.ChargeABit();

            IPhone phoneNokia = phoneFactory.CreatePhone(PhoneType.Nokia, "Nokia 3110 Test 2", 18, logger);
            phoneNokia.ChargeABit();

            TestResult(logger, $"Charging {phoneIPhone13.PhoneName} a bit");
            TestResult(logger, $"Charging {phoneNokia.PhoneName} a bit");
        }

        static void TestResult(FakeLogger logger, string checkStr)
        {
            Console.WriteLine(logger.Messages.Any(m => m.StartsWith(checkStr))
                ? "PASSED"
                : "FAILED");
        }
    }
}

