using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADovhanych_Task4
{
    abstract class Phone
    {
        public string PhoneName { get; set; }
        public int BatteryLvl { get; set; }

        public Phone() { }

        public Phone(string phoneName, int batteryLvl)
        {
            PhoneName = phoneName;
            BatteryLvl = batteryLvl;
        }

        public abstract void CallAmbulance();
    }
}
