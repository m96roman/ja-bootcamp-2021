using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Interfaces
{
    public interface IPhone
    {
        int BatteryLevel { get; set; }
        string PhoneName { get; set; }
        string Type { get; set; }

        void CallAmbulance();
        void Charge();
        void ChargeABit();
    }
}
