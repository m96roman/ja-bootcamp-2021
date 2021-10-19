using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class Vehicle
    {
        public int Mileage  { get; set; }
        public string CarName { get; set; }
        private readonly int Year;

        public CanCarryTrack CanCarryTrack { get; set; } = new CanCarryTrack();
        public CanCarryCar CanCarryCar { get; set; } = new CanCarryCar();

        public Vehicle(int mileage, string carName, int year)
        {
            Mileage = mileage;
            CarName = carName;
            Year = year;
        }

        public Vehicle() : this(0, null, 2018) { }

        public virtual void PrintVehicleDetails()
        {
            Console.WriteLine($"Car Name -> {CarName} Mileage -> {Mileage} Year -> {Year}");
        }

        public void PrintCarConstructedAge()
        {
            Console.WriteLine($"Car is constructed in {Year}");
        }
    }
}
