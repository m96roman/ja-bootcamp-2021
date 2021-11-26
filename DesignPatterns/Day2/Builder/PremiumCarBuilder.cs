using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class PremiumCarBuilder : CarBuilder
    {
        public override void BuildChair()
        {
            this.Car.Chair = "no heating";
        }

        public override void BuildEngine()
        {
            this.Car.Engine = " 1.8";
        }

        public override void BuildWheels()
        {
            this.Car.Wheels = " 16";
        }
    }
}
