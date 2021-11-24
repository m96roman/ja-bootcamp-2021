using ConsoleApp3.Enums;

namespace ConsoleApp3.Builders
{
    public abstract class CarBuilder
    {
        public Car _car { get; private set; }
        public CarModels CarModel { get; set; }

        public void CreateCar()
        {
            _car = new Car();
        }

        public abstract void ChooseEngine();
        public abstract void ChooseSeat();
        public abstract void ChooseDisks();
        public abstract void ChooseModel();
        public abstract void SetComplectation();
    }
}
