using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedakTask4
{
    class PhoneEmergencyTestHolder : IEnumerable
    {
        public List<ITelephone> telephones = new List<ITelephone>();

        public static void TestEmergency(PhoneEmergencyTestHolder phoneEmergency)
        {
            foreach (Phone phone in phoneEmergency)
            {
                try
                {
                    phone.CallAmbulance();
                }
                catch (BatteryIsDeadException)
                {
                    if ( phone is not Nokia nokia)
                    {
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

        IEnumerator IEnumerable.GetEnumerator()
           => telephones.GetEnumerator();
    }
}
