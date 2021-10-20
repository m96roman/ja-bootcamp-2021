using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDedenok_Task4
{
    class Nokia : Phone
    {
        public void PrayForBattery()
        {
            BatteryLevel += 8;
            Console.WriteLine($"Praying for the battery of {this.GetType().Name}, batteryLevel is now {this.BatteryLevel}!");
        }
    }
}
