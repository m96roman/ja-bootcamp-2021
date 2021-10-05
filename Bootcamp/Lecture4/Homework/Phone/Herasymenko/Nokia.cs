using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herasymenko
{
    public class Nokia : PhoneBaseClass
    {
        public void PrayForBattery()
        {
            if(BatteryLevel > 92)
            {
                Console.WriteLine("Your phone is not nedded in charge right now, try do it later.");
            }
            else
            {
                BatteryLevel += 8;
                Console.WriteLine("Ppraying for the battery");
            }
        }
    }
}
