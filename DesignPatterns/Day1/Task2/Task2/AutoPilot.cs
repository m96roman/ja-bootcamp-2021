using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class AutoPilot
    {

        public void Navigate(string destination, IDrivable _transport)
        {
            Console.WriteLine($"Navigate to destination {destination}");
            _transport.GoForward();
            _transport.TurnLeft();
            _transport.GoBackward();
            _transport.TurnRight();
        }

        public void Navigate(string destination, IRailable _transport)
        {
            Console.WriteLine($"Navigate to destination {destination}");
            _transport.GoForward();
            _transport.GoBackward();
        }
    }
}
