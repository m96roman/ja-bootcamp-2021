using ConsoleApp3.Builders;

namespace ConsoleApp3
{
    public class Diller
    {
        public Car Deliver(CarBuilder buildCar)
        {
            buildCar.CreateCar();
            buildCar.ChooseDisks();
            buildCar.ChooseEngine();
            buildCar.ChooseSeat();
            buildCar.ChooseModel();

            return buildCar._car;
        }
    }
}
