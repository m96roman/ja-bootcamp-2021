using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPlyskaLect4
{
    public class Phone
    {
        public int BatteryLevel { get; set; }

        public void Charge()
        {
            BatteryLevel = 100;
            Console.WriteLine($"Charging {this} to 100%");
        }
        public void ChargeABit()
        {
            BatteryLevel += 1;
            Console.WriteLine($"Charging {this} by 1%");
        }
        public void CallAmbulance()
        {
            if (BatteryLevel < 0 || BatteryLevel > 100)
            {
                throw new InappropriateBatteryLevelValueException("Charging of battery can not be less than 0 or more 100");
            }

            if (BatteryLevel >= 5)
            {
                BatteryLevel -= 5;
                Console.WriteLine($"calling an ambulance from {this}, remaining charge: {BatteryLevel}%");
            }
            
            if (BatteryLevel < 5)
            {
                BatteryLevel = 0;
                throw new BatteryIsDeadException(this.ToString());
            }
        }

    }
}
