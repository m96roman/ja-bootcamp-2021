using System;

namespace KFedakTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneEmergencyTestHolder phone = new PhoneEmergencyTestHolder();
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    phone.TestEmergency();
                }
                catch (BatteryIsDeadException be)
                {
                    be.telephone.Charge();
                }
            }
        }
    }
}
