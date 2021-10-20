using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADovhanych_Task4
{
    class Nokia : Phone, ICharge
    {
        public Nokia(int batterLvl, ILogger logger = null) : base(batterLvl, logger) { }

        public void PrayForBatery()
        {
            BatteryLvl += 8;
            Console.WriteLine($"Charging {GetType().Name}");
        }

        public void Charge()
        {
            BatteryLvl = 100;
            _logger.LogInfo($"Charging {GetType().Name} to 100%");
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
