using System;
using System.Collections.Generic;

namespace KFedak_TDD
{
    public class Program
    {
        public const int iteration = 10;

        public static ILogger logger = new Logger();

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
    }
}
