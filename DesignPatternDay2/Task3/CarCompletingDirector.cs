using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class CarCompletingDirector
    {
        CarComplectation carBuilder;
        public CarCompletingDirector(CarComplectation builder)
        {
            this.carBuilder = builder;
        }

        public void CompleteCar()
        {
            carBuilder.EngineCapacity();
            carBuilder.WheelSize();
            carBuilder.SeatHeater();
        }

        public string ShowResult()
        {
            Console.WriteLine(carBuilder.GetRusultedCarComplectation());
            return carBuilder.GetRusultedCarComplectation();
        }
    }
}
