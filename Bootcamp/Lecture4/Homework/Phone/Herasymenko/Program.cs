using System;

namespace Herasymenko
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneEmergencyTestHolder holder = new PhoneEmergencyTestHolder();

            IMobile[] mobiles = new IMobile[]
            {
                new IPhone {BatteryLevel = 4, PhoneModel = "IPhoneX"},
                new IPhone {BatteryLevel = 12, PhoneModel = "IPhone6"},
                new IPhone {BatteryLevel = 16, PhoneModel = "IPhone13"},
                new IPhone {BatteryLevel = 3, PhoneModel = "IPhoneS"},
                new IPhone {BatteryLevel = 33, PhoneModel = "IPhone7"},
                new Nokia {BatteryLevel = 4, PhoneModel = "Nokia 3310"},
                new Nokia {BatteryLevel = 55, PhoneModel = "Nokia 6233"},
                new Nokia {BatteryLevel = 70, PhoneModel = "Nokia 6230"},
                new Nokia {BatteryLevel = 4, PhoneModel = "Nokia 6230I"}
            };

            foreach (IMobile mobile in mobiles)
            {
                holder.TestEmergency(mobile);
            }
        }
    }
}
