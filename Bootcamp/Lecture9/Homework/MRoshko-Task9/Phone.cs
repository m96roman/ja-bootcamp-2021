using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRoshko_Task9
{
    public class Phone
    {
        protected int BatteryLevel { get; set; }

        public Phone(int batteryLevel)
        {
            SetBatteryLevel(batteryLevel);
        }

        public void SetBatteryLevel(int batteryLevel)
        {
            if (batteryLevel >= 0 && batteryLevel <= 100)
            {
                this.BatteryLevel = batteryLevel;
            }
            else
            {
                throw new InvalidOperationException("invalid value is provided");
            }
        }

        public void CallAmbulance()
        {
            if (this.BatteryLevel >= 5)
            {
                this.BatteryLevel -= 5;

                Console.WriteLine($"calling an ambulance from {GetType()}, remaining charge: {this.BatteryLevel} % ");
            }
            else
            {
                this.BatteryLevel = 0;

                throw new BatteryIsDeadException(this, $"BatteryIsDeadException {GetType()}");
            }
        }

        public void Charge()
        {
            this.BatteryLevel = 100;

            Console.WriteLine($"Charging {GetType()} to 100%");
        }

        public void ChargeABit()
        {
            if (BatteryLevel >= 100)
            {
                BatteryLevel = 100;
            }
            else 
            {
                this.BatteryLevel += 1;
            }           

            Console.WriteLine($"Charging {GetType()} by 1%");
        }

        public void PrintBatteryLevel()
        {
            Console.WriteLine($"{this.BatteryLevel}");
        }
    }
}
