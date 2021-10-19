using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADovhanych_Task4
{
    class IPhone : Phone, ICharge
    {
        public IPhone(int batteryLvl) : base(batteryLvl) { }

        public void Charge()
        {
            BatteryLvl = 100;
            Console.WriteLine($"Charging {GetType().Name} to 100%");
        }

        public void ChargeABit()
        {
            if (BatteryLvl >= 0 && BatteryLvl < 100)
            {
                BatteryLvl += 1;
                Console.WriteLine($"Charging {GetType().Name} by 1%");
            }
            else
            {
                throw new InvalidBatteryLevelException();
            }
        }
    }
}
