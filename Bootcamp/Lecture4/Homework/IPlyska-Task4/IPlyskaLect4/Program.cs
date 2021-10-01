using System;
using System.Collections.Generic;

namespace IPlyskaLect4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Phone> container = new List<Phone>()
            {
                new Nokia{BatteryLevel = 5},
                new IPhone13{BatteryLevel = 10},
                new Nokia{BatteryLevel = 25},
                new IPhone13{BatteryLevel = 8},
                new Nokia{BatteryLevel = 12}
            };

            PhoneEmergencyTestHolder phone = new PhoneEmergencyTestHolder(container);
            int counter = 1;
            while (counter != 10)
            {
                try
                {
                    PhoneEmergencyTestHolder.TestEmergency(phone);       
                }
                catch (BatteryIsDeadException ex)
                {
                    ex.phone.Charge(); 
                }

               counter++;
            }
               
            Console.ReadLine();
        }
    }
}
