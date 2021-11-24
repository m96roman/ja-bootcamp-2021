using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class AutoPilotTrain
    {
        private IDrivableTrain _transportForwardBack;

        public AutoPilotTrain(IDrivableTrain transportForwardBack)
        {
            _transportForwardBack = transportForwardBack;
        }

        public void Navigate(string destination)
        {
            Console.WriteLine($"Navigate to destination {destination}");
            _transportForwardBack.GoForward();
            _transportForwardBack.GoBackward();
        }
    }
}
