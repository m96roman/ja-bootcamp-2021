using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public abstract class VehicleProperties
    {
        public virtual string CanCarry { get; set; }

        public abstract void PrintVehicleProperties();

        public VehicleProperties(string carry)
        {
            CanCarry = carry;
        }
    }
}
