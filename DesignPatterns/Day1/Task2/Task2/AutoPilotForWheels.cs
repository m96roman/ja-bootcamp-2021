using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class AutoPilotForWheels: IAutoPilot
    {
        private IDriveableLeftAndRight _transport;

        public AutoPilotForWheels(IDriveableLeftAndRight transport)
        {
            _transport = transport;
        }

        public void Navigate(string destination)
        {
            Console.WriteLine($"Navigate to destination {destination}");
            _transport.GoForward();
            _transport.TurnLeft();
            _transport.GoBackward();
            _transport.TurnRight();
        }
    }
}
