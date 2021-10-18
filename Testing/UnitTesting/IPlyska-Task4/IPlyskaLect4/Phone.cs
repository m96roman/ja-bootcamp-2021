using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPlyskaLect4
{
    public class Phone
    {
        private int batteryLevel;
        public int BatteryLevel 
        {
            get 
            {
                return batteryLevel;
            }
            set 
            {
                if (value < 0 || value > 100)
                {
                    throw new InappropriateBatteryLevelValueException("Charging of battery can not be less than 0 or more 100");
                }

                batteryLevel = value;
            }    
        }

        public void Charge()
        {
            BatteryLevel = 100;
            Loger.Log($"Charging {this.GetType().Name} to 100%");
        }

        public void ChargeABit()
        {
            BatteryLevel += 1;
            Loger.Log($"Charging {this.GetType().Name} by 1%");
        }

        public void CallAmbulance()
        {

            if (BatteryLevel >= 5)
            {
                BatteryLevel -= 5;
                Loger.Log($"calling an ambulance from {this.GetType().Name}, remaining charge: {BatteryLevel}%");
            }
            else
            {
                BatteryLevel = 0;
                throw new BatteryIsDeadException(this.ToString());
            }
        }

    }
}
