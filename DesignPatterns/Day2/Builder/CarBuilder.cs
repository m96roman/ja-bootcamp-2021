using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
 internal abstract   class CarBuilder
    {
        public Car Car { get; private set; }

        public CarBuilder()
        {
            Car = new Car();
        }

        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildChair();
    }
}
