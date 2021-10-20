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
        private List<Phone> phones = new List<Phone>();

        public PhoneEmergencyTestHolder(List<Phone> phones)
        {
            if (phones is null || phones.Count == 0)
            {
                throw new ArgumentNullException("phones", "Parameter can not be null or an empty");
            }

            this.phones = phones;
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

                    ex.phone = phone;
                    Loger.Log($"Phone failed to call an ambulance: {phone.GetType()}");

                    throw;
                }
                catch (Exception ex)
                {
                    Loger.Log(ex.Message); 
                }
                finally
                {
                    phone.ChargeABit();
                }
            }
         
        }
    }
}
