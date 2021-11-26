using System;
using System.Collections.Generic;
using System.Text;

namespace Task5_Mediator
{
    public class ThirdShip : BaseShip
    {
        public void SendMessageToSecond()
        {
            Console.WriteLine("Send to Second from Third");
        }

        public void SendMessageToFirst()
        {
            Console.WriteLine("Send to First from  Third");
        }
    }
}
