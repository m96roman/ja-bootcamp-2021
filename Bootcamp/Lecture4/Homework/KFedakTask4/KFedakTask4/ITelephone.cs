using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedakTask4
{
    interface ITelephone
    {
        public string PhoneName { get; set; }

        public byte BatteryLevel { get; set; }

        void CallAmbulance();

        void Charge();

        void ChargeABit();
    }
}
