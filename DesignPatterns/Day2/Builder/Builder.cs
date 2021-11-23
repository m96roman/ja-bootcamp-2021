using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Builder : IBuilder
    {
        private Car car;

        public Builder(string name)
        {
            Reset(name);
        }

        public void Reset(string name)
        {
            car = new Car(name);
        }

        public void BuildChair(string name)
        {
            car.Add(name);
        }

        public void BuildEngine(string name)
        {
            car.Add(name);
        }

        public void BuildWheels(string name)
        {
            car.Add(name);
        }

        public Car GetCar()
        {
            Car result = car;
            Reset(result.Name);
            return result;
        }
    }
}
