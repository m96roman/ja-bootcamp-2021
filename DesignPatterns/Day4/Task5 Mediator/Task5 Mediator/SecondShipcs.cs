using System;
using System.Collections.Generic;
using System.Text;

namespace Task5_Mediator
{
   public class SecondShip: BaseShip
    {
        public void SendMessageToFirst()
        {
            Console.WriteLine("Send to First from  Second");
        }

        public void SendMessageToThird()
        {
            Console.WriteLine("Send to Third from Second");
        }
    }
}
