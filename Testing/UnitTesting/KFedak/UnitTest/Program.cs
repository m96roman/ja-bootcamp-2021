using System;
using System.Collections.Generic;
using System.Diagnostics;
using KFedak_Task9;
using NUnit.Framework;

namespace UnitTest
{
    class Program
    {
        static void Main(string[] args)
        {

            ValidBatteryLevel(-5,"Iphon 10");
            ValidBatteryLevel(4, "Iphon 13");

            Console.WriteLine("\n");

            var phoneAmmbulance = new List<Phone>
            {
                new IPhone(4, "Iphone13"),
                new IPhone(25, "Iphone7")
            };

            CheckCallAmbulance(phoneAmmbulance);

            Console.WriteLine("\n");

            var phoneCharge = new List<Phone>
            {
                new IPhone(40, "Iphone13"),
                new IPhone(25, "Iphone7")
            };

            CheckCharge(phoneCharge);

            Console.WriteLine("\n");

            var phoneChargeABit = new List<Phone>
            {
                new IPhone(4, "Iphone13"),
                new IPhone(25, "Iphone7")
            };

            CheckChargeABit(phoneChargeABit);

            Console.WriteLine("\n");

            var phonePrayForBattery = new List<Nokia>
            {
                new Nokia(4, "Nokia"),
            };

            CheckPrayForBattery(phonePrayForBattery);
        }


        static void ValidBatteryLevel(int battery,string name )
        {
                try
                {
                    Phone phone = new IPhone(battery, name);
                    if (phone.BatteryLevel >= 0 && phone.BatteryLevel <= 100)
                    {
                        Console.WriteLine("ValidBatteryLevel was passed!!!" + $"\n{phone.BatteryLevel}");
                    }
                }
                catch (InvalidValueForBattery ex)
                {
                    Console.WriteLine(ex.Message,ex.batteryLevel);
                    Console.WriteLine("ValidBatteryLevel was failed!!!\n");
                } 
        }

        static void CheckCallAmbulance(List<Phone> phones)
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
                    }
                }
                catch (BatteryIsDeadException)
                {
                    if (phone.BatteryLevel == 0)
                    {
                        Console.WriteLine("When we catch BatteryException");
                        Console.WriteLine($"The start level of charge was {currentLevel} and after CallAmbulance() {phone.BatteryLevel}");
                        Console.WriteLine("PASSED\n");
                    }
                    else
                    {
                        Console.WriteLine("Failed\n");
                    }
                }
            }
        }

        static void CheckCharge(List<Phone> phones)
        {
            var currentLevel = 0;
            foreach (var phone in phones)
            {
                currentLevel = phone.BatteryLevel;
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

        static void CheckChargeABit(List<Phone> phones)
        {
            var currentLevel = 0;
            foreach (var phone in phones)
            {

                currentLevel = phone.BatteryLevel;
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
            var currentLevel = 0;
            foreach (var phone in phones)
            {
                currentLevel = phone.BatteryLevel;
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

