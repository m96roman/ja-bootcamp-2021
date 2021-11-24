using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.CarModels;

namespace Task3
{
    class BasicCarComplectation : CarComplectation
    {
        Car car;
        public BasicCarComplectation(Car currentCar)
        {
            this.car = currentCar;
        }
        public override string EngineCapacity()
        {
            return "1,5 l";
        }
        public override string WheelSize()
        {
            return "15 inch";
        }
        public override string SeatHeater()
        {
           return "no seat heater";
        }
        public override string  GetRusultedCarComplectation()
        {
            string result = $"Car {car.CarModel()} is ordered in Basic complectation: {EngineCapacity()}, {WheelSize()}, {SeatHeater()}.";
            return result;
        }

    }
}
