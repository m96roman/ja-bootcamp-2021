using System;

namespace KFedakTask4
{
    class Program
    {
        public const int iteration = 10;

        static void Main(string[] args)
        {
            PhoneEmergencyTestHolder phone = new PhoneEmergencyTestHolder();

            CreatePhones(phone);

            for (int i = 0; i < iteration; i++)
            {
                try
                {
                    PhoneEmergencyTestHolder.TestEmergency(phone);
                }
                catch (BatteryIsDeadException ex)
                {
                    ex.Telephone.Charge();
                }
            }
        }

        public static void CreatePhones(PhoneEmergencyTestHolder testHolder)
        {
            testHolder.telephones.Add(new IPhone(4, "Iphone13"));
            testHolder.telephones.Add(new Nokia(8, "345"));
            testHolder.telephones.Add(new IPhone(25, "Iphone7"));
        }
    }
}
