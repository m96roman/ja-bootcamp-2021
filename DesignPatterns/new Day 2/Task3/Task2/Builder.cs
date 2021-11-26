using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Builder
    {
        public Car Build(CarBuilder carBuilder)
        {
            carBuilder.CreateCar();
            carBuilder.SetEngine();
            carBuilder.SetWarm();
            carBuilder.SetDisks();
            return carBuilder.Car;
        }
    }
}
