using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Distributor
    {
        public Car Make(CarBuilder carBuilder, string name)
        {
            carBuilder.Car.Name = name;
            carBuilder.BuildChair();
            carBuilder.BuildEngine();
            carBuilder.BuildWheels();

            return carBuilder.Car;
        }
    }
}
