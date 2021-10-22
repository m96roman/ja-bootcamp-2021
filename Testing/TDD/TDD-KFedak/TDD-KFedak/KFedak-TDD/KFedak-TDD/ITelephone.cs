﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedak_TDD
{
    public interface ITelephone
    {
        string PhoneName { get; set; }

        int BatteryLevel { get; set; }

        void CallAmbulance();

        void Charge();

        void ChargeABit();
    }
}
