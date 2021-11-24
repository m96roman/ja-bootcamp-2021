using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.CarModels;

namespace Task3
{
    class SuperMegaCarComplectation : CarComplectation
    {
        Car car;
        public SuperMegaCarComplectation(Car currentCar)
        {
            this.car = currentCar;
        }
        public override string EngineCapacity()
        {
            return "1,6 l";
        }
        public override string WheelSize()
        {
            return "16 inch";
        }
        public override string SeatHeater()
        {
            return "seat heater present";
        }
        public override string GetRusultedCarComplectation()
        {
            string result = $"Car {car.CarModel()} is ordered in SuperMega complectation: {EngineCapacity()}, {WheelSize()}, {SeatHeater()}.";
            return result;
        }
    }
}
