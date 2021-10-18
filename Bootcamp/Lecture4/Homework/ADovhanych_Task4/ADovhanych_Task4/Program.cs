using System;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("UnitTestsPhonesApp")]


namespace ADovhanych_Task4
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            Phone[] phones = new Phone[]
            {
                new Nokia(4),
                new Nokia(8),
                new IPhone(25),
                new IPhone(10),
                new IPhone(3)
            };

            PhoneEmergencyTestHolder phoneEmergency = new PhoneEmergencyTestHolder(phones);

            for (int i = 0; i < 10; i++)
            {
                try
                {
                    PhoneEmergencyTestHolder.TestEmergency(phoneEmergency);
                }
                catch (BatteryIsDeadException)
                {
                    throw;
                }
            }
        }
    }
}
