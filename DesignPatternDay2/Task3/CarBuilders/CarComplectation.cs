using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.CarModels;

namespace Task3
{
   
    public abstract class CarComplectation
    {
        public abstract string EngineCapacity();
        public abstract string WheelSize();
        public abstract string SeatHeater();
        public abstract string GetRusultedCarComplectation();
    }
}
