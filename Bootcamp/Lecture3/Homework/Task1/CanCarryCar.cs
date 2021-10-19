using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class CanCarryCar : VehicleProperties
    {
        public override string CanCarry { get => base.CanCarry; }
        public CanCarryCar(string canCarry) : base(canCarry) { }
        public CanCarryCar() : this(null) { }

        public override void PrintVehicleProperties()
        {
            Console.WriteLine($"This vehicle can carry luggage? {CanCarry}");
        }
    }
}
