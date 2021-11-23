using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Car : AutoPilot, IDrivable
    {
        public void GoForward()
        {
            Console.WriteLine("Car is going forward.");
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
            Console.WriteLine("Car is backing up.");
        }
       
        public override void Navigate(string destination)
        {
            Console.WriteLine($"Navigate to destination {destination}");
            GoForward();
            TurnLeft();
            TurnRight();
            GoBackward();
        }
    }
}
