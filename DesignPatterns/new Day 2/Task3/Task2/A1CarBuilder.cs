using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class A1CarBuilder : CarBuilder
    {
        public override void SetDisks()
        {
            this.Car.Disks = new Disks { Size = "15" };
        }

        public override void SetEngine()
        {
            this.Car.Engine = new Engine { Capasity = "1.5" };
        }

        public override void SetWarm()
        {
            this.Car.Warm = new Warm { Availability = "No" };
        }
    }
}
