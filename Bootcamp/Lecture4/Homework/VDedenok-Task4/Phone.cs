using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDedenok_Task4
{
    class Phone
    {  
        private int batteryLevel;
        const int fullBattery = 100;
        const int lowLevel = 5;

        public int BatteryLevel
        {
            get
            {
                return batteryLevel;
            }
            set
            {
                try
                {
                    if (value < fullBattery && value > 0)
                    {
                        batteryLevel = value;
                    }
                    else
                    {
                        throw new PhoneOverflowException($"Datas are unappopriate on {this.GetType().Name}!");
                    }
                }
                catch (PhoneOverflowException ex)
                {
                    Console.WriteLine(ex.ShowMessage);
                }
            }       
        }

        public void CallAmbulance()
        {
            if (this.batteryLevel >= lowLevel)
            {
                batteryLevel -= 5;
                Console.WriteLine($"Calling an ambulance from {this.GetType().Name}, remaining charge: {batteryLevel}%.");
            }
            else if (this.batteryLevel < lowLevel)
            {
                batteryLevel = 0;
                throw new BatteryIsDeadException($"Phone failed to call an ambulance: {this.GetType().Name}.", this);
            };
        }

        public void Charge()
        {
            this.batteryLevel = 100;
            Console.WriteLine($"Charging {this.GetType().Name} to 100%.");
        }

        public void ChargeABit()
        {
            batteryLevel += 1;
            Console.WriteLine($"Charging {this.GetType().Name} by 1%.");
        }
    }
}
