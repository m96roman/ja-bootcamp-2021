using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
     class AutoPilot:IAutoPilot
    {
        private IAvto _transport;

        public AutoPilot(IAvto transport)
        {

            _transport = transport;
        }

        public void Navigate(string destination)
        {
            Console.WriteLine($"Navigate to destination {destination}");
           
            _transport.TurnLeft();
            _transport.TurnRight();
            _transport.GoForward();
            _transport.GoBackward();


        }
    }
}
