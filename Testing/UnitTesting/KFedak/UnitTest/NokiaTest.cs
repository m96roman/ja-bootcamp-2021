using KFedak_Task9;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnitTest;

namespace KFedak_UnitTest1
{
    class NokiaTest : TestPhone
    {
        public FakeLogger fakeLogger { get; set; }

        public NokiaTest(FakeLogger fakeLogger) : base(fakeLogger)
        {
            this.fakeLogger = fakeLogger;
        }

        public void CheckPrayForBattery(List<Phone> phones)
        {
            foreach (var phone in phones)
            {
                int currentLevel = phone.BatteryLevel;
                if (phone is Nokia nokia)
                {
                    nokia.PrayForBattery();
                    if (phone.BatteryLevel == currentLevel + 8)
                    {
                        Console.WriteLine("\nPASSED CheckPrayForBattery");
                        Console.WriteLine($"'CurrentLevel'={currentLevel}, after PrayForBattery() {phone.BatteryLevel}");
                    }
                    else
                    {
                        Console.WriteLine($"'CurrentLevel'={currentLevel}, after PrayForBattery() {phone.BatteryLevel}");
                        Console.WriteLine("Failed\n");
                    }
                }
            }
        }

        public void CheckPrayForBatteryLogged(List<Phone> phones)
        {
            foreach (var phone in phones)
            {
                if (phone is Nokia nokia)
                {
                    nokia.PrayForBattery();
                    if (fakeLogger.message.Contains("Praying for the battery"))
                    {
                        Console.WriteLine("PASSED CheckPrayForBatteryLogged\n");
                    }
                    else
                    {
                        Console.WriteLine("Failed\n");
                    }
                }
            }
        }

    }
}
