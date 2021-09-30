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
            
            phones.Add(new Nokia("Nokia", 20));
            phones.Add(new IPhone13("Iphone", 20));

            foreach (var phone in phones)
            {
                //((IPhoneMethods)phone).CallAmbulance();
                phones.TestEmergency((PhoneEmergencyTestHolder)phone);
                Console.WriteLine(phones);
               
            }
        }
    }
}
