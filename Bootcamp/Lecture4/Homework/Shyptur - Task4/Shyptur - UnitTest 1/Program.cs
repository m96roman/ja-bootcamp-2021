using Shyptur___Task4;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shyptur___UnitTest_1
{
    internal class Program
    {
        static void TestBattery_InvalidValue(int battaryLevel)
        {
            try
            {
                Nokia phone = new Nokia(battaryLevel);
            }
            catch (Exception ex)
            {
                if (ex is BatteryIsDeadException)
                {
                    Console.WriteLine($"TestBattery PASSED for invalid value {battaryLevel}");
                }
                else
                {
                    Console.WriteLine("TestBattery failed, wrong exception type" + ex.GetType());
                }

                return;
            }

            Console.WriteLine("TestBattery failed, no exception ");
        }
        static void TestBattery_SholdtSetCorrectValue(int battaryLevel)
        {
            Nokia phone = new Nokia(battaryLevel);
            if (phone.BateryLevel == battaryLevel)
            {
                Console.WriteLine($"TestBattery PASSED for correct value {battaryLevel}");
            }
            else
            {
                Console.WriteLine($"TestBattery FAILED for correct value {battaryLevel}");
            }
        }
        static void TestBattery_PrayForBatterry(FakeLogger logger)
        {
            Nokia phone = new Nokia(90, logger);
            phone.PrayForBattery();

            if (phone.BateryLevel == 98)
            {
                if (logger.Messages.Any(m => m.Contains("praying for the battery")))
                {
                    Console.WriteLine("Test PrayForBatterry PASSED");
                }
                else
                {
                    Console.WriteLine($"Test PrayForBatterry failed, " +
                        $"wrong message: {string.Join(Environment.NewLine, logger.Messages)}");
                }
            }
            else
            {
                Console.WriteLine($"Test PrayForBatterry failed, {phone.BateryLevel}");
            }
        }

        static void Test_CallAmbulance_ShouldSetCorrectValue(FakeLogger logger)
        {
            Nokia phone = new Nokia(90, logger);
            phone.CallAmbulance();

            if (phone.BateryLevel == 85)
            {
                if (logger.Messages.Any(m => m.Contains("calling an ambulance from")))
                {
                    Console.WriteLine("Test_CallAmbulance PASSED");
                }
                else
                {
                    Console.WriteLine($"Test_CallAmbulance failed, " +
                        $"wrong message: {string.Join(Environment.NewLine, logger.Messages)}");
                }
            }
            else
            {
                Console.WriteLine($"Test_CallAmbulance failed {phone.BateryLevel}");
            }
        }

        static void Test_CallAmbulance_ShouldSetIncorrectValue(FakeLogger logger)
        {
            Nokia phone = new Nokia(4, logger);

            try
            {
                phone.CallAmbulance();
            }
            catch (Exception ex)
            {
                if (ex is BatteryIsDeadException)
                {
                    Console.WriteLine($"Test_CallAmbulance_ShouldSetIncorrectValue PASSED battery lvl = {phone.BateryLevel}");
                }
                else
                {
                    Console.WriteLine("Test_CallAmbulance_ShouldSetIncorrectValue FAILED exception type" + ex.GetType());
                }

                return;
            }

            Console.WriteLine("Test_CallAmbulance_ShouldSetIncorrectValue FAILED no exception");
        }

        static void Test_ChargeaBit()
        {
            Nokia phone = new Nokia(100);
            phone.ChargeaBit();

            if (phone.BateryLevel == 100)
            {
                Console.WriteLine("Test_ChargeaBit PASSED");
            }
            else
            {
                Console.WriteLine($"Test_ChargeaBit FAILED phone battery level = {phone.BateryLevel}");
            }
        }


        static void Main(string[] args)
        {
            var logger = new FakeLogger();
            TestBattery_InvalidValue(-20);
            TestBattery_InvalidValue(101);
            TestBattery_PrayForBatterry(logger);
            TestBattery_SholdtSetCorrectValue(90);
            Test_CallAmbulance_ShouldSetCorrectValue(logger);
            Test_CallAmbulance_ShouldSetIncorrectValue(logger);
            Test_ChargeaBit();
        }
    }
}


