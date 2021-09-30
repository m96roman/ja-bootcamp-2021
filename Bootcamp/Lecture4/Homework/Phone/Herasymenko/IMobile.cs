using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herasymenko
{
    public interface IMobile
    {
        public int BatteryLevel { get; set; }
        public string PhoneModel { get; set; }

        void CallAmbulance();

        void Charge();

        void ChargeBit();

    }
}
