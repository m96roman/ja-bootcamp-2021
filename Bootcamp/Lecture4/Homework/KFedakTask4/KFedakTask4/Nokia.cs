using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedakTask4
{
    class Nokia : ITelephone
    {
        public string PhoneName { get; set; }
        public byte BatteryLevel { get; set; }

        public Nokia(byte battery, string name)
        {
            if (0 <= battery && battery <= 100)
            {
                this.BatteryLevel = battery;
                this.PhoneName = name;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(battery), "Invalid value!");
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
                throw new BatteryIsDeadException();
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

        public void PrayForBattery()
        {
            this.BatteryLevel += 8;
            Console.WriteLine("praying for the battery");
        }
    }
}
