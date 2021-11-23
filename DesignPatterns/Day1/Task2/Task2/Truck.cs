using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Truck : IDrivable
    {
        public void GoForward()
        {
            Console.WriteLine("Truck goes forward.");
        }

        public void TurnLeft()
        {
            Console.WriteLine("Truck turns left.");
        }

        public void TurnRight()
        {
            Console.WriteLine("Truck turns right.");
        }

        public void GoBackward()
        {
            Console.WriteLine("Truck is backing up.");
        }

        public void Navigate(string destination)
        {
            Console.WriteLine($"Navigate to destination {destination}");
            GoForward();
            TurnLeft();
            GoBackward();
            TurnRight();
        }
    }
}

