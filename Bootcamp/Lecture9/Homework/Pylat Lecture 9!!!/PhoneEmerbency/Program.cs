using Pylat_Lecture_9___.Task4;
using System;
using System.Collections.Generic;
using System.IO;

namespace Pylat_Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1 ////////////////////

            //Task1.DoTask1();

            // Task 4 Lecture 9 ///////////////

            PhoneEmergencyTestHolder phones = new PhoneEmergencyTestHolder();
            Logger logger = new Logger();
            Task1 task1 = new Task1();
            phones.Add(new Nokia("Nokia", 25));
            phones.Add(new Nokia("Nokia", 4));
            phones.Add(new Nokia("Nokia", 8));
            phones.Add(new IPhone13("Iphone", 25));
            phones.Add(new IPhone13("Iphone", 66));
            phones.Add(new IPhone13("Iphone", 45));
            phones.Add(new IPhone13("Iphone", 87));

            phones.Add(new IPhone13("Iphone", 8));

            for (int i = 0; i < 10; i++)
            {
                try
                {
                    task1.TesmEmergency(phones);
                }
                catch (PhoneExceptions ex)
                {
                    
                    ex.phone.Charge();
                    
                }
            }
        }
    }
}
