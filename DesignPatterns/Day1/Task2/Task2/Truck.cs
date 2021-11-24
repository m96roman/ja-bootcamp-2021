using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Truck : IDrivable
    {
        public override void GoForward()
        {
            Console.WriteLine("Truck going forward.");
        }

        public override void TurnLeft()
        {
            Console.WriteLine("Truck turns left.");
        }

        public override void TurnRight()
        {
            Console.WriteLine("Truck turns right.");
        }

        public override void GoBackward()
        {
            Console.WriteLine("Truck backing up.");
        }
    }
}
