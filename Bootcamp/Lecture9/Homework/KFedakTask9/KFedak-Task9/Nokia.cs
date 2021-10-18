using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedak_Task9
{
    class Nokia : Phone, ITelephone
    {
        public Nokia(int battery, string name) : base(battery, name) { }

        public void PrayForBattery()
        {
            this.BatteryLevel += 8;

            Console.WriteLine("Praying for the battery");
        }
    }
}
