using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedakTask4
{
    public abstract class Phone : ITelephone
    {
        public string PhoneName { get; set; }
        public byte BatteryLevel { get; set; }

        public Phone(byte batteryLevel, string phoneName)
        {
            this.PhoneName = phoneName;
            if (batteryLevel < 0 || batteryLevel > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(batteryLevel), "Invalid value!");
            }
            else
            {
                this.BatteryLevel = batteryLevel;
            }
        }

        public void CallAmbulance()
        {
            if (this.BatteryLevel >= 5)
            {
                this.BatteryLevel -= 5;
                Console.WriteLine($"Calling an ambulance from {PhoneName}, remaining charge: {BatteryLevel}%");
            }
            else
            {
                this.BatteryLevel = 0;
                throw new BatteryIsDeadException(this);
            }
        }

        public void Charge()
        {
            this.BatteryLevel = 100;
            Console.WriteLine($"Charging {PhoneName} to 100%");
        }

        public void ChargeABit()
        {
            this.BatteryLevel += 1;
            Console.WriteLine($"Charging {PhoneName} by 1%");
        }
    }
}
