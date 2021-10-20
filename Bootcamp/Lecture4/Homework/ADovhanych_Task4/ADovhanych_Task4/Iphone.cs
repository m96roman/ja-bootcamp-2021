using System;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("UnitTestsPhonesApp")]

namespace ADovhanych_Task4
{
    internal class IPhone : Phone, ICharge
    {
        public IPhone(int batteryLvl, ILogger logger = null) : base(batteryLvl, logger) { }

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
