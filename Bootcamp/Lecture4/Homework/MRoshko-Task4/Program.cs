using System;
using System.Collections;
namespace MRoshko_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone[] myPhones = new Phone[]
            {
                new IPhone13(7),
                new Nokia(8),
                new Nokia(16),
                new IPhone13(24),
                new Nokia(32),
                new Nokia(64),
                new IPhone13(23),
                new IPhone13(6),
                new IPhone13(24),
                new IPhone13(21),
                new Nokia(5)
            };

            PhoneEmergencyTestHolder phones = new PhoneEmergencyTestHolder(myPhones);

            for (int i = 0; i < 10; i++)
            {
                try
                {
                    TestEmergency(phones);
                }
                catch (BatteryIsDeadException ex)
                {
                    ex.Instance.Charge();
                }
            }
        }

        public static void TestEmergency(PhoneEmergencyTestHolder phoneEmergencyTestHolder)
        {
            foreach (Phone phone in phoneEmergencyTestHolder)
            {
                try
                {
                    phone.CallAmbulance();
                }
                catch (BatteryIsDeadException ex)
                {
                    if (phone is Nokia nokiaPhone)
                    {
                        nokiaPhone.PrayForBattery();

                        nokiaPhone.CallAmbulance();

                        continue;
                    }

                    Console.WriteLine($"Phone failed to call an ambulance: {phone.GetType()}");

                    throw;
                }
                finally
                {
                    phone.ChargeABit();
                }
            }

            Console.WriteLine();
        }
    }
}
