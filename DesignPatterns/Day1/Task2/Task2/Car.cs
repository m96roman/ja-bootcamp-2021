using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Car : ICarAndTruck, IDrivableForwardAndBackward, IDriveableLeftAndRight
    {
        public void GoForward()
        {
            Console.WriteLine("Car going forward.");
        }

        public void TurnLeft()
        {
            Console.WriteLine("Car turns left.");
        }

        public void TurnRight()
        {
            Console.WriteLine("Car turns right.");
        }

        public void GoBackward()
        {
            Console.WriteLine("Car backing up.");
        }
    }
}
