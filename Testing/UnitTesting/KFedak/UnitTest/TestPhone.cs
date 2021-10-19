using KFedak_Task9;
using KFedak_UnitTest1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public abstract class TestPhone : ITestable
    {
        public FakeLogger fakeLogger { get; set; }

        public TestPhone(FakeLogger logger)
        {
            fakeLogger = logger;
        }

        public void ValidBatteryLevelCheckException(int battery, string name)
        {
            try
            {
                Phone phone = new Nokia(battery, name, fakeLogger);
            }
            catch (InvalidValueForBattery)
            {
                Console.WriteLine("ValidBatteryLevelCheckException Passed!!!\n" + $"{battery}\n");
                return;
            }
            Console.WriteLine("ValidBatteryLevelCheckException Faild!!!\n" + $"{battery}\n");
        }

        public void ValidBatteryLevelCheckValue(int battery, string name)
        {
            try
            {
                Phone phone = new Nokia(battery, name, fakeLogger);
            }
            catch (InvalidValueForBattery)
            {
                Console.WriteLine("ValidBatteryLevelCheckValue Faild!!!\n" + $"{battery}\n");
                return;
            }
            Console.WriteLine("ValidBatteryLevelCheckValue Passed!!!\n" + $"{battery}\n");
        }

        public void ValidBatteryLevelCheckExceptionLogged()
        {
            try
            {
                var p = new Nokia(-5, "6788", fakeLogger);
            }
            catch (InvalidValueForBattery ex)
            {
                if (fakeLogger.message.Contains(ex.Message))
                {
                    Console.WriteLine("PASSED ValidBatteryLevelLogged\n");
                }
                return;
            }
        }

        public  void CheckCallAmbulance(List<Phone> phones)
        {
            var currentLevel = 0;
            foreach (var phone in phones)
            {
                try
                {
                    currentLevel = phone.BatteryLevel;
                    phone.CallAmbulance();
                    if (currentLevel >= 5 && phone.BatteryLevel == currentLevel - 5)
                    {
                        Console.WriteLine("\nPASSED CheckCallAmbulance");
                        Console.WriteLine($"'CurrentLevel'={currentLevel}, after CallAmbulance() {phone.BatteryLevel}");
                        return;
                    }
                }
                catch (BatteryIsDeadException)
                {
                    if (phone.BatteryLevel == 0)
                    {
                        Console.WriteLine("\nPASSED CheckCallAmbulance");
                        Console.WriteLine("When we catch BatteryException");
                        Console.WriteLine($"The start level of charge was {currentLevel} and after CallAmbulance() {phone.BatteryLevel}");
                        return;
                    }
                }

                Console.WriteLine("Failed\n");
            }
        }

        public void CheckCallAmbulanceLogged(List<Phone> phones)
        {
            foreach (var phone in phones)
            {
                try
                {
                    phone.CallAmbulance();
                }
                catch (BatteryIsDeadException ex)
                {
                    if (fakeLogger.message.Contains(ex.Message))
                    {
                        Console.WriteLine("PASSED CheckCallAmbulanceLogged\n");
                    }
                    return;
                }
            }
        }

        public  void CheckCharge(List<Phone> phones)
        {
            foreach (var phone in phones)
            {
                int currentLevel = phone.BatteryLevel;
                phone.Charge();
                if (phone.BatteryLevel == 100)
                {
                    Console.WriteLine("\nPASSED CheckCharge");
                    Console.WriteLine($"'CurrentLevel'={currentLevel}, after Charge() {phone.BatteryLevel}");
                }
                else
                {
                    Console.WriteLine($"'CurrentLevel'={currentLevel}, after Charge() {phone.BatteryLevel}");
                    Console.WriteLine("Failed\n");
                }
            }
        }

        public void CheckChargeLogged(List<Phone> phones)
        {
            foreach (var phone in phones)
            {
                int currentLevel = phone.BatteryLevel;
                phone.Charge();
                if (fakeLogger.message.Contains($"Charging {phone.PhoneName} to 100%"))
                {
                    Console.WriteLine("PASSED CheckChargeLogged\n");
                    return;
                }
                else
                {
                    Console.WriteLine("Failed\n");
                }
            }
        }

        public  void CheckChargeABit(List<Phone> phones)
        {
            foreach (var phone in phones)
            {
                int currentLevel = phone.BatteryLevel;
                phone.ChargeABit();
                if (phone.BatteryLevel == currentLevel + 1)
                {
                    Console.WriteLine("\nPASSED CheckChargeABit");
                    Console.WriteLine($"'CurrentLevel'={currentLevel}, after ChargeABit() {phone.BatteryLevel}\n");
                }
                else
                {
                    Console.WriteLine($"'CurrentLevel'={currentLevel}, after ChargeABit() {phone.BatteryLevel}\n");
                    Console.WriteLine("Failed\n");
                }
            }
        }

        public void CheckChargeABitLogged(List<Phone> phones)
        {
            foreach (var phone in phones)
            {
                int currentLevel = phone.BatteryLevel;
                phone.ChargeABit();
                if (fakeLogger.message.Contains($"Charging {phone.PhoneName} by 1%"))
                {
                    Console.WriteLine("PASSED CheckChargeABitLogged\n");
                    return;
                }
                else
                {
                    Console.WriteLine("Failed\n");
                }
            }
        }

    }
}
