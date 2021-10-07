using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADovhanych_Task9._4
{
    class IPhone : Phone, ICharge
    {
        public IPhone(int batteryLvl)
        {
            BatteryLvl = batteryLvl;
        }

        public void Charge()
        {
            BatteryLvl = 100;
            Console.WriteLine($"Charging {GetType().Name} to 100%");
        }

        public void ChargeABit()
        {
            BatteryLvl += 1;
            Console.WriteLine($"Charging {GetType().Name} by 1%");
        }
    }
}
