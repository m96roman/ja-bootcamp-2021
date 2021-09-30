using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herasymenko
{
    public class PhoneEmergencyTestHolder
    {
        public void TestEmergency(IMobile phone)
        {
            try
            {
                phone.CallAmbulance();

                if (phone is Nokia nokia)
                {
                    nokia.PrayForBattery();
                    phone.CallAmbulance();
                }

            }
            catch (BatteryIsDeadException)
            {
                phone.Charge();
            }
            finally
            {
                phone.ChargeBit();
            }
        }
    }
}
