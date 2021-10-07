using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADovhanych_Task9._4
{
    public class Phone
    {
        public string PhoneName { get; set; }
        public int BatteryLvl { get; set; }

        public Phone() { }

        public Phone(string phoneName, int batteryLvl)
        {
            PhoneName = phoneName;
            BatteryLvl = batteryLvl;
        }

        public void CallAmbulance()
        {
            if (BatteryLvl > 100 || BatteryLvl < 0)
            {
                throw new InvalidPhoneChargeException();
            }

            if (BatteryLvl >= 5)
            {
                BatteryLvl -= 5;
                Console.WriteLine($"Calling an ambulance from {GetType().Name}, remaining charge: {BatteryLvl}");
            }
            else
            {
                BatteryLvl = 0;
                throw new BatteryIsDeadException();
            }
        }
    }
}
