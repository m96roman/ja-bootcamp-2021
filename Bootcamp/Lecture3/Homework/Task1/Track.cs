using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class Track : Vehicle
    {
        public string Type { get; set; }

        public Track() : base() { }
        public Track(string type) : base()
        {
            Type = type;
        }

        public override void PrintVehicleDetails()
        {
            base.PrintVehicleDetails();
            Console.WriteLine($"The position of this person is: { Type }");
        }
    }
}
