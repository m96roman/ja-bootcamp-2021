using ConsoleApp3.Enums;
using ConsoleApp3.Models;
using ConsoleApp3.Structs;

namespace ConsoleApp3.Builders
{
    public class SuperMegaCarBuilder : CarBuilder
    {
        public override void ChooseDisks()
        {
            this._car.DiametrDisk = new Disk { Diametr = Disks.Two };
        }

        public override void ChooseEngine()
        {
            this._car.EngineCapacity = new Engine { Power = Engines.Three };
        }

        public override void ChooseSeat()
        {
            this._car.SeatHeat = new Seat { Heat = Seats.HeatIs };
        }

        public override void ChooseModel()
        {
            this._car.ModelCar = CarModel;
        }

        public override void SetComplectation()
        {
            this._car.Complect = Complectations.SuperMega;
        }
    }
}
