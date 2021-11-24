using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_Adapter
{
   public class HomingPigeon : IHomingPigeon
    {
        public void SendByPigeon(string text)
        {
            Console.WriteLine(@$"Message: {text}");
            Console.WriteLine("Sent by Homing Pigeon");
        }
    }
}
