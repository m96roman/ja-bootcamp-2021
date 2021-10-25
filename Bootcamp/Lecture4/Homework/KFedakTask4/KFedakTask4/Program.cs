using System;
using System.Collections.Generic;

namespace KFedakTask4
{
    class Program
    {
        public const int iteration = 10;

        static void Main(string[] args)
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
            var holder = new List<Phone>();
            holder.Add(new IPhone(4, "Iphone13"));
            holder.Add(new Nokia(8, "345"));
            holder.Add(new IPhone(25, "Iphone7"));

            return holder;
        }
    }
}
