using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class AutoPilotBase:IAutoPilot
    {
        private Train transport;

        public AutoPilotBase(Train transport)
        {
            this.transport = transport;
        }

        public void Navigate(string destination)
        {
            Console.WriteLine($"Navigate to destination {destination}");
            transport.GoForward();
            transport.GoBackward();
        }
    }
}
