using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADovhanych_Task4
{
    internal class Phone
    {
        public string PhoneName { get; set; }
        public int BatteryLvl { get; set; }
        protected ILogger _logger { get; set; }

        public Phone(int batteryLvl, ILogger logger = null)
        {
            _logger = logger ?? new PhoneLogger();
            
            if (batteryLvl > 0 && batteryLvl < 100)
            {
                BatteryLvl = batteryLvl;
            }
            else
            {
                throw new InvalidBatteryLevelException();
            }
        }

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
