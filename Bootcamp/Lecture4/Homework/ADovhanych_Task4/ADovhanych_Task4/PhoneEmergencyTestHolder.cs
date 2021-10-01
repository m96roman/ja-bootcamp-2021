using System;
using System.Collections;

namespace ADovhanych_Task4
{
    class PhoneEmergencyTestHolder : IEnumerable
    {
        public Phone[] phoneInstance = new Phone[3];

        public PhoneEmergencyTestHolder()
        {
            try
            {
                phoneInstance[0] = new Iphone() { BatteryLvl = 4, PhoneName = "iPhone1" };
                phoneInstance[1] = new Nokia() { BatteryLvl = 8, PhoneName = "Nokia10" };
                phoneInstance[2] = new Iphone() { BatteryLvl = 25, PhoneName = "Iphone2" };
            }
            catch (InvalidPhoneChargeException)
            {
                throw new InvalidPhoneChargeException();
            }

        }

        public IEnumerator GetEnumerator()
        {
            return phoneInstance.GetEnumerator();
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
                    }

                    Console.WriteLine($"Phone failed to call an ambulance");
                }
            }
        }
    }
}
