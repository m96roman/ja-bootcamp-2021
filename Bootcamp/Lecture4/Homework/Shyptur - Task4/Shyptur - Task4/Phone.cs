using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shyptur___Task4
{
    abstract class Phone
    {
        public int BateryLevel { get; set; }

        public string phoneName { get; set; }

        public void CallAmbulance()
        {
            if (BateryLevel >= 5)
            {
                BateryLevel -= 5;
                Console.WriteLine($"calling an ambulance from {this.GetType().Name}, remaining charge: {100 - BateryLevel} % ;");
            }
            else
            {
                throw new BatteryIsDeadException()
                {
                    PhoneInfo = this
                };
            }
        }

        public void Charge()
        {
            BateryLevel = 100;
            Console.WriteLine($"Charging {this.GetType().Name} to 100%");
        }

        public void ChargeaBit()
        {
            BateryLevel += 1;
            Console.WriteLine($"Charging {this.GetType().Name} by 1%");
        }
    }
}
