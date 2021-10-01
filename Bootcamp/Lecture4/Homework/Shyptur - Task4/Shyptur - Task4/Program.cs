using System;

namespace Shyptur___Task4
{
    class Program
    {
        public static void TestEmergency(PhoneEmergencyTestHolder phoneEmergencyTestHolder)
        {
            foreach (Phone phone in phoneEmergencyTestHolder)
            {
                try
                {
                    phone.CallAmbulance();

                }
                catch (BatteryIsDeadException)
                {
                    if (phone is Nokia nokiaPhone)
                    {                       
                        nokiaPhone.PrayForBattery();
                        nokiaPhone.CallAmbulance();
                    }
                    else
                    {
                        throw;
                    }
                }
                finally
                {
                    phone.ChargeaBit();
                }
            }
        }
        static void Main(string[] args)
        {

            Phone[] phones = new Phone[]
            {
             new Nokia(4),
                new Nokia(8),
                new Nokia(25),
                new IPhone13(4),
                new IPhone13(8),
                new IPhone13(25)
            };

            PhoneEmergencyTestHolder phoneEmergencyTestHolder = new PhoneEmergencyTestHolder(phones);

            for (int i = 0; i < 9; i++)
            {
                try
                {
                    TestEmergency(phoneEmergencyTestHolder);
                }
                catch (BatteryIsDeadException ex)
                {
                    ex.PhoneInfo.Charge();
                }
            }
        }
    }
}
