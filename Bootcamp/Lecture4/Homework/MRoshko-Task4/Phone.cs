using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRoshko_Task4
{
    public class Phone
    {
        internal int batteryLevel { get; set; }

        public Phone(string batteryLevel)
        {
            SetBatteryLevel(batteryLevel);
        }

        public void SetBatteryLevel(string batteryLevel)
        {
            bool state = int.TryParse(batteryLevel, out int numb);
            if (numb >= 0 && numb <= 100 && state || numb == 0)
            {
                this.batteryLevel = numb;
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

                var log = new Logger($"Calling an ambulance from {GetType()}, remaining charge: {this.batteryLevel} % ");
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

            var log = new Logger($"Charging {GetType()} to 100%");
        }

        public void ChargeABit()
        {

            if (this.batteryLevel + 1 >= 100)
            {
                this.batteryLevel = 100;
            }
            else 
            {
                this.batteryLevel += 1;
            }
            var log = new Logger($"Charging {GetType()} by 1%");
        }

        public void PrintBatteryLevel()
        {
            Console.WriteLine($"{this.batteryLevel}");
        }
    }
}
