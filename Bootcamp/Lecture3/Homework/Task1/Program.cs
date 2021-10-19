using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[]
            {
                new Audi
                {
                    CarName = "Audi Q8",
                    Mileage = 10000
                },
                new Bmw
                {
                    CarName = "Bmw I8",
                    Mileage = 12000
                },
                new Man
                {
                    CarName = "Man 534",
                    Mileage = 120000
                },
                new Volvo
                {
                    CarName = "Volvo VR",
                    Mileage = 150000
                },
                new Vehicle
                {
                    CarName = "Wolksvagen",
                    Mileage = 0
                },
                new Audi
                {
                    CarName = "Audi Q7",
                    Mileage = 200
                }
            };

            foreach (var vehicle in vehicles)
            {
                if (vehicle is Car)
                {
                    vehicle.CanCarryCar.CanCarry = "No";
                    vehicle.CanCarryCar.PrintVehicleProperties();
                }
                else
                {
                    vehicle.CanCarryTrack.CanCarry = "Yes";
                    vehicle.CanCarryTrack.PrintVehicleProperties();
                }
                vehicle.PrintVehicleDetails();
                vehicle.PrintCarConstructedAge();
            }
        }
    }
}
