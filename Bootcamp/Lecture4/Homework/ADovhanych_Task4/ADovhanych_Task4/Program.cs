using System;

namespace ADovhanych_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneEmergencyTestHolder phones = new PhoneEmergencyTestHolder();
            int times = 1;

            while (times != 10)
            {
                try
                {
                    PhoneEmergencyTestHolder.TestEmergency(phones);
                }
                catch (BatteryIsDeadException ex)
                {
                    Console.WriteLine(ex);
                }

                times++;
            }
        }
    }
}
