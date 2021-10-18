using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRoshko_Task4
{
    public class Nokia : Phone
    {
        public Nokia(string batteryLevel) : base(batteryLevel)
        {

        }

        public void PrayForBattery()
        {
            if (batteryLevel + 8 >= 100)
            {
                this.batteryLevel = 100;
            }
            else 
            {
                this.batteryLevel += 8;
            }

            Console.WriteLine($"praying for the battery");
        }
    }
}
