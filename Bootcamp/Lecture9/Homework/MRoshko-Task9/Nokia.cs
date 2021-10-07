using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRoshko_Task9
{
    public class Nokia : Phone
    {
        public Nokia(int batteryLevel) : base(batteryLevel)
        {

        }
        public void PrayForBattery()
        {
            this.batteryLevel += 8;

            Console.WriteLine($"praying for the battery");
        }
    }
}
