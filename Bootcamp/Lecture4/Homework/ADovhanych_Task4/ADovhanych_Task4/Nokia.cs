using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADovhanych_Task4
{
    class Nokia : Phone, ICharge
    {
        public Nokia()
        { }

        public Nokia(string phoneName, int batteryLvl) : base(phoneName, batteryLvl)
        {
            PhoneName = phoneName;
            BatteryLvl = batteryLvl;
        }

        public void PrayForBatery()
        {
            BatteryLvl += 8;
            Console.WriteLine($"Charging {PhoneName}");
        }

        public void Charge()
        {
            BatteryLvl = 100;
            Console.WriteLine($"Charging {PhoneName} to 100%");
        }

        public void ChargeABit()
        {
            BatteryLvl += 1;
            Console.WriteLine($"Charging {PhoneName} by 1%");
        }

        public override void CallAmbulance()
        { 
            if (BatteryLvl >= 5)
            {
                BatteryLvl -= 5;
                Console.WriteLine($"Calling an ambulance from {PhoneName}, remaining charge: {BatteryLvl}");
            }
            else
            {
                BatteryLvl = 0;
                throw new BatteryIsDeadException();
            }
        }
    }
}
