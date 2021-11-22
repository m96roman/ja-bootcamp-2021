using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class AutoPilotCar
    {
        private IDrivableCar _transportCar;

        public AutoPilotCar(IDrivableCar transportCar)
        {
            _transportCar = transportCar;
        }

        public void Navigate(string destination)
        {
            Console.WriteLine($"Navigate to destination {destination}");
            _transportCar.GoForward();
            _transportCar.GoBackward();
            _transportCar.TurnLeft();
            _transportCar.TurnRight();
        }
    }
}
