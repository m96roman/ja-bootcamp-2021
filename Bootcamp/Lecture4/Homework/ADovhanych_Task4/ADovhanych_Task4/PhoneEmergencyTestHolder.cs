using System;
using System.Collections;

namespace ADovhanych_Task4
{
    class PhoneEmergencyTestHolder : IEnumerable
    {
        Phone[] phones;
        IEnumerator IEnumerable.GetEnumerator() => phones.GetEnumerator();

        public PhoneEmergencyTestHolder(Phone[] phones)
        {
            this.phones = phones;
        }

        public static void TestEmergency(PhoneEmergencyTestHolder phoneInstance)
        {
            foreach (Phone phone in phoneInstance)
            {
                try
                {
                    phone.CallAmbulance();
                }
                catch (BatteryIsDeadException)
                {
                    if (phone is Nokia nokiaPhone)
                    {
                        nokiaPhone.PrayForBatery();
                        nokiaPhone.CallAmbulance();
                    }

                    Console.WriteLine($"Phone failed to call an ambulance {phone.GetType().Name}");
                }
            }
        }
    }
}
