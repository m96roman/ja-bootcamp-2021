using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task4.Interfaces;
using Task4.Exceptions;

namespace Task4
{
    public class Nokia : IPhone
    {
        private int _batteryLevel;

        public int BatteryLevel
        {
            get => _batteryLevel;
            set
            {
                if(Enumerable.Range(0, 100).Contains(value))
                {
                    _batteryLevel = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Battery range must be between 0 and 100");
                }
            }
        }

        public string PhoneName { get; set; }
        public string Type { get; set; }

        public void CallAmbulance()
        {
            if(BatteryLevel >= 5)
            {
                BatteryLevel -= 5;
                Console.WriteLine($"calling an ambulance from {PhoneName}, remaining charge: {_batteryLevel}%");
            }
            else
            {
                BatteryLevel = 0;

                Logger.WriteLine($"{PhoneName} have died battery!");
                throw new Exceptions.BatteryIsDeadException($"{PhoneName} have died battery!")
                {
                    Phone = this
                };
            }
        }

        public void Charge()
        {
            BatteryLevel = 100;
            Console.WriteLine($"Charging {PhoneName} to 100%");
        }

        public void ChargeABit()
        {
            BatteryLevel = 1;
            Console.WriteLine($"Charging {PhoneName} by 1%");
        }

        public void PrayForBattery()
        {
            BatteryLevel += 8;
            Console.WriteLine("praying for the battery");
        }
    }
}
