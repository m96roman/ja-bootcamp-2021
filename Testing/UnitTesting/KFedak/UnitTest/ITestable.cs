using KFedak_Task9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedak_UnitTest1
{
    interface ITestable
    {
        public FakeLogger fakeLogger { get; set; }

        void ValidBatteryLevelCheckException(int battery, string name) { }

        void ValidBatteryLevelCheckValue(int battery, string name) { }

        void ValidBatteryLevelCheckExceptionLogged() { }

        static void CheckCallAmbulance(List<Phone> phones) { }
        void CheckCallAmbulanceLogged(List<Phone> phones) { }

        static void CheckCharge(List<Phone> phones) { }

        void CheckChargeLogged(List<Phone> phones) { }
        static void CheckChargeABit(List<Phone> phones) { }

        void CheckChargeABitLogged(List<Phone> phones) { }

    }
}
