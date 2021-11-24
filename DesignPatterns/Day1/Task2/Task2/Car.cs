using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Car : IDrivable
    {
        public override void GoForward()
        {
            Console.WriteLine("Car going forward.");
        }

        public override void TurnLeft()
        {
            Console.WriteLine("Car turns left.");
        }

        public override void TurnRight()
        {
            Console.WriteLine("Car turns right.");
        }

        public override void GoBackward()
        {
            Console.WriteLine("Car backing up.");
        }
    }
}
