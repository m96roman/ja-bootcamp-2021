using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herasymenko
{
    public class PhoneBaseClass : IMobile
    {
        public int BatteryLevel { get; set; }
        public string PhoneModel { get; set; }

        public void CallAmbulance()
        {

            if (BatteryLevel >= 5)
            {
                BatteryLevel -= 5;
                Console.WriteLine($"calling an ambulance from {PhoneModel}, remaining charge: {BatteryLevel}");
            }
            else
            {
                BatteryLevel = 0;
                throw new BatteryIsDeadException(PhoneModel);
            }
        }

        public void Charge()
        {
            BatteryLevel = 100;
            Console.WriteLine($"Charging {PhoneModel} to 100%");
        }

        public void ChargeBit()
        {
            if (BatteryLevel == 100)
            {
                Console.WriteLine($"The Battery is fully charged for {PhoneModel}");
            }
            else
            {
                BatteryLevel += 1;
                Console.WriteLine($"Charging {PhoneModel} by 1%");
            }
        }
    }
}
