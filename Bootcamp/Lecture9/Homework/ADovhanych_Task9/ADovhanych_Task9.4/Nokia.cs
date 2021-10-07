using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADovhanych_Task9._4
{
    class Nokia : Phone, ICharge
    {
        public Nokia(int batteryLvl)
        { 
            BatteryLvl = batteryLvl;
        }

        public void PrayForBatery()
        {
            BatteryLvl += 8;
            Console.WriteLine($"Charging {GetType().Name}");
        }

        void ICharge.Charge()
        {
            BatteryLvl = 100;
            Console.WriteLine($"Charging {GetType().Name} to 100%");
        }

        void ICharge.ChargeABit()
        {
            BatteryLvl += 1;
            Console.WriteLine($"Charging {GetType().Name} by 1%");
        }
    }
}
