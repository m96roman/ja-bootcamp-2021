using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class Car : Vehicle
    {
        private string Type { get; set; }

        public Car() : base() { }
        public Car(string type) : base()
        {
            Type = type;
        }

        public override void PrintVehicleDetails()
        {
            base.PrintVehicleDetails();
            Console.WriteLine($"Type of the car is: { Type }");
        }
    }
}
