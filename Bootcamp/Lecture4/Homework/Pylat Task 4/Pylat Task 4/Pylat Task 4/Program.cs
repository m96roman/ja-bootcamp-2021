using System;
using System.Collections.Generic;

namespace Pylat_Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1.DoTask1();

            PhoneEmergencyTestHolder phones = new PhoneEmergencyTestHolder();
            

            phones.Add(new Nokia("Nokia", 25));
            phones.Add(new Nokia("Nokia", 4));
            phones.Add(new Nokia("Nokia", 8));
            phones.Add(new IPhone13("Iphone", 25));
            phones.Add(new IPhone13("Iphone", 4));
            phones.Add(new IPhone13("Iphone", 8));

            for (int i = 0 ; i < 10; i++)
            {
                try
                {
                    Task1.TesmEmergency(phones);
                }
                catch(PhoneExceptions ex)
                {
                    ex.phone.Charge();
                }
            }

        }
    }
}
