using ConsoleApp3.Models;
using ConsoleApp3.Enums;

namespace ConsoleApp3
{
    public class Car
    {
        public Disk DiametrDisk { get; set; }
        public Engine EngineCapacity { get; set; }
        public Seat SeatHeat { get; set; }
        public CarModels ModelCar { get; set; }
        public Complectations Complect { get; set; }

        public override string ToString()
        {
            return $"car {ModelCar} {Complect}";
        }
    }
}
