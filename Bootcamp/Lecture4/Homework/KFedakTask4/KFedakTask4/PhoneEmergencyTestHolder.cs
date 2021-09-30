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

        public PhoneEmergencyTestHolder()
        {
            telephones.Add(new IPhone(4, "Iphone13"));
            telephones.Add(new Nokia(8, "345"));
            telephones.Add(new IPhone(25, "Iphone7"));
        }

        public void TestEmergency()
        {
            foreach (var phone in telephones)
            {
                try
                {
                    phone.CallAmbulance();
                    if (phone.GetType() == typeof(Nokia))
                    {
                        var p = phone as Nokia;
                        p.PrayForBattery();
                        phone.CallAmbulance();
                    }
                }
                catch (BatteryIsDeadException)
                {
                   // throw;
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
