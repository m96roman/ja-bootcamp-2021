using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRoshko_Task9
{
    public class Phone
    {
        protected int batteryLevel;

        public Phone(int batteryLevel)
        {
            SetBatteryLevel(batteryLevel);
        }

        public void SetBatteryLevel(int batteryLevel)
        {
            if (batteryLevel >= 0 && batteryLevel <= 100)
            {
                this.batteryLevel = batteryLevel;
            }
            else
            {
                throw new InvalidOperationException("invalid value is provided");
            }
        }

        public void CallAmbulance()
        {
            if (this.batteryLevel >= 5)
            {
                this.batteryLevel -= 5;

                Console.WriteLine($"calling an ambulance from {GetType()}, remaining charge: {this.batteryLevel} % ");
            }
            else
            {
                this.batteryLevel = 0;

                throw new BatteryIsDeadException(this, $"BatteryIsDeadException {GetType()}");
            }
        }

        public void Charge()
        {
            this.batteryLevel = 100;

            Console.WriteLine($"Charging {GetType()} to 100%");
        }

        public void ChargeABit()
        {
            this.batteryLevel += 1;

            Console.WriteLine($"Charging {GetType()} by 1%");
        }

        public void PrintBatteryLevel()
        {
            Console.WriteLine($"{this.batteryLevel}");
        }
    }
}
