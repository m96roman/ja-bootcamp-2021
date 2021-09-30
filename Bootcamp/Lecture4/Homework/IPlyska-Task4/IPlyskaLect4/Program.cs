using System;

namespace IPlyskaLect4
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneEmergencyTestHolder phone = new PhoneEmergencyTestHolder();
            int counter = 1;
            while (counter != 10)
            {
                try
                {
                    PhoneEmergencyTestHolder.TestEmergency(phone);       
                }
                catch (BatteryIsDeadException ex)
                {
                    Console.WriteLine(ex.Message);
                }

               counter++;
            }
               
            Console.ReadLine();
        }
    }
}
