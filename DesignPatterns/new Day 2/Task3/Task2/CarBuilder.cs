using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    abstract class CarBuilder
    {
        public Car Car { get; private set; }
        public void CreateCar()
        {
            Car = new Car();
        }
        public abstract void SetEngine();
        public abstract void SetDisks();
        public abstract void SetWarm();
    }
}

