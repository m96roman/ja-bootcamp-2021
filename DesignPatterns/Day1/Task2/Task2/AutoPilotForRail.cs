using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class AutoPilotForRail:IAutoPilot
    {
        private Train _transport;

        public AutoPilotForRail(Train transport)
        {
            _transport = transport;
        }

        public void Navigate(string destination)
        {
            Console.WriteLine($"Navigate to destination {destination}");
            _transport.GoForward();         
            _transport.GoBackward();          
        }
    }
}
