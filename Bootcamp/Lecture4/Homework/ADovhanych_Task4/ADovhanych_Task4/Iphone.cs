using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADovhanych_Task4
{
    class IPhone : Phone, ICharge
    {
        public IPhone(int batteryLvl)
        {
            if (batteryLvl > 0 && batteryLvl < 100)
            {
                BatteryLvl = batteryLvl;
            }
            else
            {
                throw new InvalidBatteryLevelException();
            }
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
