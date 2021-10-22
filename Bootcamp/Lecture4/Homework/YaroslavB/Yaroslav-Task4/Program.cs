using System;

namespace Yaroslav_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneEmergencyTestHolder phoneHolder = GetPhoneCollection();
            AdvancedTestPhoneEmergency test = new AdvancedTestPhoneEmergency(phoneHolder, new Logger());

            test.CycleTestEmergency(10);


            Console.WriteLine("\n\nPress \'Enter\' to exit...");
            Console.ReadLine();
        }

        private static PhoneEmergencyTestHolder GetPhoneCollection()
        {
            var phones = new PhoneEmergencyTestHolder()
            {
                new Nokia(4),
                new IPhone13(8),
                new Nokia(25),
                new IPhone13(42)
            };

            return phones;
        }
    }
}
