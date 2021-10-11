using System;
namespace Pylat_Task_4
{

    public class Nokia : PhoneBase, INokiaPhone
    {
        public Nokia(string typeOfPhone, int bateryLevel) : base(typeOfPhone, bateryLevel)
        { }      
      
        public void PrayForBattery()
        {
            if (BateryLevel < 93)
            {
                BateryLevel += 8;
            }
            else
            {
                BateryLevel = 100;
            }
                                       
            Console.WriteLine("Praying for the battery");
        }
    }
}

