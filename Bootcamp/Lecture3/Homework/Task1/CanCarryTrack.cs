using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class CanCarryTrack : VehicleProperties
    {
        public override string CanCarry { get => base.CanCarry; }
        public CanCarryTrack(string canCarry) : base(canCarry) { }
        public CanCarryTrack() : this(null) { }

        public override void PrintVehicleProperties()
        {
            Console.WriteLine($"This vehicle can carry luggage? {CanCarry}");
        }
    }
}
