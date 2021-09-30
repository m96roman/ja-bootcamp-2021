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

        public Phone(byte betteryLevel, string phoneName)
        {
            this.PhoneName = phoneName;
            if (betteryLevel < 0 || betteryLevel > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(betteryLevel), "Invalid value!");
            }
            else
            {
                this.BatteryLevel = betteryLevel;
            }
        }

        public void CallAmbulance()
        {
            if (this.BatteryLevel >= 5)
            {
                this.BatteryLevel -= 5;
                Console.WriteLine($"calling an ambulance from {PhoneName}, remaining charge: {BatteryLevel}%");
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
