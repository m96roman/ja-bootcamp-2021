using System;
using System.Collections.Generic;
using System.Text;

namespace Task5_Mediator
{
    public class FirstShip : BaseShip
    {
        public void SendMessageToSecond()
        {
            Console.WriteLine("Send to Second from First");
        }

        public void SendMessageToThird()
        {
            Console.WriteLine("Send to Third from First");
        }
    }
}
