using KFedak_Task9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedak_UnitTest1
{
    public class NokiaTest : ITestable
    {
        public FakeLogger fakeLogger;

        public NokiaTest(FakeLogger logger)
        {
            fakeLogger = logger;
        }

        public void RunLogger(List<Phone> phone)
        {
            CheckCallAmbulanceLogged(phone);
           // ValidBatteryLevelLogged();
        }

        public void RunTest()
        {
            ValidBatteryLevel(-5, "10");

            Console.WriteLine("\n");

            var phoneAmmbulance = new List<Nokia>
            {
                new Nokia(4, "546"),
                new Nokia(25, "211")
            };

            CheckCallAmbulance(phoneAmmbulance);

            Console.WriteLine("\n");

            var phoneCharge = new List<Nokia>
            {
                new Nokia(40, "567"),
                new Nokia(25, "123")
            };

            CheckCharge(phoneCharge);

            Console.WriteLine("\n");

            var phoneChargeABit = new List<Nokia>
            {
                new Nokia(4, "78"),
                new Nokia(25, "8400")
            };

            CheckChargeABit(phoneChargeABit);

            var phonePrayForBattery = new List<Nokia>
            {
                new Nokia(4, "Nokia"),
            };

            CheckPrayForBattery(phonePrayForBattery);
        }

        public void ValidBatteryLevel(int battery, string name)
        {
            try
            {
                Phone phone = new Nokia(battery, name);
            }
            catch (InvalidValueForBattery)
            {
                Console.WriteLine("ValidBatteryLevel was passed!!!");
                return;
            }

            Console.WriteLine("ValidBatteryLevel was failed!!!\n");
        }

        public void ValidBatteryLevelLogged()
        {
            try
            {
                var holder = new List<Phone>
                {
                    new IPhone(4, "Iphone13"),
                    new Nokia(-5, "345"),
                    new IPhone(25, "Iphone7")
                };
            }
            catch (InvalidValueForBattery ex)
            {
                if (fakeLogger.message.Contains(ex.Message))
                {
                    Console.WriteLine("PASSED");
                    Console.WriteLine("Correct message!");
                }
            }
        }

        static void CheckCallAmbulance(List<Nokia> phones)
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
                        Console.WriteLine($"'CurrentLevel'={currentLevel}, after CallAmbulance() {phone.BatteryLevel}");
                        Console.WriteLine("PASSED\n");
                        return;
                    }
                }
                catch (BatteryIsDeadException)
                {
                    if (phone.BatteryLevel == 0)
                    {
                        Console.WriteLine("When we catch BatteryException");
                        Console.WriteLine($"The start level of charge was {currentLevel} and after CallAmbulance() {phone.BatteryLevel}");
                        Console.WriteLine("PASSED\n");
                        return;
                    }
                }

                Console.WriteLine("Failed\n");
            }
        }

        void CheckCallAmbulanceLogged(List<Phone> phones)
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
                        Console.WriteLine("PASSED");
                        Console.WriteLine("Correct message!");
                    }
                    return;
                }
            }
        }

        static void CheckCharge(List<Nokia> phones)
        {
            foreach (var phone in phones)
            {
                int currentLevel = phone.BatteryLevel;
                phone.Charge();
                if (phone.BatteryLevel == 100)
                {
                    Console.WriteLine($"'CurrentLevel'={currentLevel}, after Charge() {phone.BatteryLevel}");
                    Console.WriteLine("PASSED\n");
                }
                else
                {
                    Console.WriteLine($"'CurrentLevel'={currentLevel}, after Charge() {phone.BatteryLevel}");
                    Console.WriteLine("Failed\n");
                }
            }
        }

        static void CheckChargeABit(List<Nokia> phones)
        {
            foreach (var phone in phones)
            {
                int currentLevel = phone.BatteryLevel;
                phone.ChargeABit();
                if (phone.BatteryLevel == currentLevel + 1)
                {
                    Console.WriteLine($"'CurrentLevel'={currentLevel}, after ChargeABit() {phone.BatteryLevel}");
                    Console.WriteLine("PASSED\n");
                }
                else
                {
                    Console.WriteLine($"'CurrentLevel'={currentLevel}, after ChargeABit() {phone.BatteryLevel}");
                    Console.WriteLine("Failed\n");
                }
            }
        }

        static void CheckPrayForBattery(List<Nokia> phones)
        {
            foreach (var phone in phones)
            {
                int currentLevel = phone.BatteryLevel;
                phone.PrayForBattery();
                if (phone.BatteryLevel == currentLevel + 8)
                {
                    Console.WriteLine($"'CurrentLevel'={currentLevel}, after PrayForBattery() {phone.BatteryLevel}");
                    Console.WriteLine("PASSED\n");
                }
                else
                {
                    Console.WriteLine($"'CurrentLevel'={currentLevel}, after PrayForBattery() {phone.BatteryLevel}");
                    Console.WriteLine("Failed\n");
                }
            }
        }
    }
}
