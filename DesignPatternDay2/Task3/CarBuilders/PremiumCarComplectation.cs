using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.CarModels;

namespace Task3
{
    class PremiumCarComplectation : CarComplectation 
    {
        Car car;
        public PremiumCarComplectation(Car currentCar)
        {
            this.car = currentCar;
        }
        public override string EngineCapacity()
        {
            return "1,8 l";
        }
        public override string WheelSize()
        {
            return "16 inch";
        }
        public override string SeatHeater()
        {
            return "no seat heater";
        }

        public override string GetRusultedCarComplectation()
        {
            string result = $"Car {car.CarModel()} is ordered in Premium complectation: {EngineCapacity()}, {WheelSize()}, {SeatHeater()}.";
            return result;
        }
    }
}
