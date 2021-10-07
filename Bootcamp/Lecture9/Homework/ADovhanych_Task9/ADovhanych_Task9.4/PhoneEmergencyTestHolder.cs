using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADovhanych_Task9._4
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
                catch (BatteryIsDeadException ex)
                {
                    if (phone is Nokia nokiaPhone)
                    {
                        nokiaPhone.PrayForBatery();
                        nokiaPhone.CallAmbulance();
                    }
                    else
                    {
                        Logger log = new Logger();
                        log.WriteLine(ex.ToString());
                        throw;
                    }

                    Console.WriteLine($"Phone failed to call an ambulance");
                }

            }
        }
    }
}
