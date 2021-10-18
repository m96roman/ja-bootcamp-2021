using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace KFedak_Task9
{
    internal class Program
    {
        public const int iteration = 10;

        internal static void Main()
        {
            
            List<Phone> phones = CreatePhones();
            var holder = new PhoneEmergencyTestHolder(phones);

            for (int i = 0; i < iteration; i++)
            {
                try
                {
                    TestEmergency(holder);
                }
                catch (BatteryIsDeadException ex)
                {
                    Logger.WriteLine(ex);

                    ex.Telephone.Charge();
                }
            }
        }

        public static void TestEmergency(PhoneEmergencyTestHolder phoneEmergency)
        {
            foreach (Phone phone in phoneEmergency)
            {
                try
                {
                    phone.CallAmbulance();
                }
                catch (BatteryIsDeadException ex)
                {
                    Logger.WriteLine(ex);

                    if (phone is not Nokia nokia)
                    {
                        Console.WriteLine(ex.Message);
                        throw;
                    }

                    nokia.PrayForBattery();
                }
                finally
                {
                    phone.ChargeABit();
                }
            }
        }

        public static List<Phone> CreatePhones()
        {
            var holder = new List<Phone>
            {
                new IPhone(4, "Iphone13"),
                new Nokia(5, "345"),
                new IPhone(25, "Iphone7")
            };

            return holder;
        }
    }
}
