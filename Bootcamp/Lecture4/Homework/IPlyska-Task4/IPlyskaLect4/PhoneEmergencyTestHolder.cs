using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPlyskaLect4
{
    public class PhoneEmergencyTestHolder : IEnumerable
    {
        private Phone[] phones = new Phone[5];

        public PhoneEmergencyTestHolder()
        {
            phones[0] = new Nokia() { BatteryLevel = 8 };
            phones[1] = new Nokia() { BatteryLevel = 12};
            phones[2] = new IPhone13() { BatteryLevel = 10 };
            phones[3] = new Nokia() { BatteryLevel = 25};
            phones[4] = new IPhone13() { BatteryLevel = 9};
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return phones.GetEnumerator();
        }

        public static void TestEmergency(PhoneEmergencyTestHolder phones)
        {
            foreach (Phone phone in phones)
            {
                try
                {
                    phone.CallAmbulance();
                }
                catch (BatteryIsDeadException ex)
                {
                    if (phone is Nokia nokia)
                    {
                        nokia.PrayForBattery();
                    }
                   // phone.Charge();

                    Console.WriteLine($"Phone failed to call an ambulance: {phone.GetType()}");

                    throw;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    foreach (Phone phone1 in phones)
                    {
                        phone1.ChargeABit();
                    }
                }
            }
         
        }
    }
}
