using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class A5CarBuilder : CarBuilder
    {
        public override void SetDisks()
        {
            this.Car.Disks = new Disks { Size = "16" };
        }

        public override void SetEngine()
        {
            this.Car.Engine = new Engine { Capasity = "1.81" };
        }

        public override void SetWarm()
        {
            this.Car.Warm = new Warm { Availability = "Yes" };
        }
    }
}
