using KFedak_UnitTest1;
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
        internal static ILogger logger = new Logger();
        public static List<Phone> phones = new();

        internal static void Main()
        {
            try
            {
                phones = new List<Phone>
                {
                    new IPhone(4, "Iphone13",logger),
                    new Nokia(5, "345",logger),
                    new IPhone(25, "Iphone7",logger)
                };
            }
            catch (InvalidValueForBattery ex)
            {
                logger.WriteLine(ex);
            }

            var holder = new PhoneEmergencyTestHolder(phones);

            for (int i = 0; i < iteration; i++)
            {
                try
                {
                    TestEmergency(holder);
                }
                catch (BatteryIsDeadException ex)
                {
                    logger.WriteLine(ex);
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
                    logger.WriteLine(ex);

                    if (phone is not Nokia nokia)
                    {
                       // Console.WriteLine(ex.Message);
                        logger.WriteLine(ex);
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

        //public static List<Phone> CreatePhones()
        //{
        //    var holder = new List<Phone>
        //        {
        //            new IPhone(4, "Iphone13"),
        //            new Nokia(5, "345"),
        //            new IPhone(25, "Iphone7")
        //        };

        //    return holder;
        //}
    }
}
