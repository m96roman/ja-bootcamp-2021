using System;
using System.Collections.Generic;

namespace YaroslavB_Task9
{
    class TestEmergencyHelper
    {
        public static void RunTest()
        {
            List<IPhone> PhoneEmergencyTestHolder = GetPhoneCollection();
            TestAllPhones(PhoneEmergencyTestHolder, 10);
        }

        private static List<IPhone> GetPhoneCollection()
        {
            var phones = new List<IPhone>()
            {
                new Nokia(4),
                new IPhone13(8),
                new Nokia(25),
                new IPhone13(42)
            };

            return phones;
        }

        private static void TestAllPhones(List<IPhone> PhoneEmergencyTestHolder, int numberOfCalls = 3)
        {
            for (int i = 1; i <= numberOfCalls; i++)
            {
                Console.WriteLine($"\n\n================ Loop {i}/{numberOfCalls}, total phones: {PhoneEmergencyTestHolder.Count} ==============");

                try
                {
                    TestEmergency(PhoneEmergencyTestHolder);
                }
                catch (BatteryIsDeadException ex)
                {
                    ex.PhoneInstance.Charge();
                }
            }
        }

        private static void TestEmergency(List<IPhone> PhoneEmergencyTestHolder)
        {
            foreach (var phone in PhoneEmergencyTestHolder)
            {
                Console.WriteLine($"\nTrying to call ambulance from {phone.PhoneType}...");

                try
                {
                    phone.CallAmbulance();
                }
                catch (BatteryIsDeadException ex)
                {
                    var message = $"Phone failed to call an ambulance: {ex.PhoneInstance.PhoneType}";
                    Console.WriteLine(message);
                    Logger.WriteLine(ex.Message + "\t" + message);

                    if (phone is Nokia nokiaPhone)
                    {
                        nokiaPhone.PrayForBattery();
                        phone.CallAmbulance();
                        continue;
                    }

                    throw;
                }
                finally
                {
                    phone.ChargeABit();
                }
            }
        }
    }
}
