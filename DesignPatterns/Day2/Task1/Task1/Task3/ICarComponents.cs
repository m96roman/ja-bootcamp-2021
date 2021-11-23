using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public interface ICarComponents
    {
        void Engine(double engine);
        void DiametrWheels(int diametr);
        void heatedSeats(bool value);
        string GetModelCar();
    }
}
