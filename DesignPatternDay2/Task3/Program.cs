using System;
using Task3.CarModels;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car firstOrderCar = new CarModelA2();
            Car secondOrderCar = new CarModelA2();

            CarComplectation premiumBuilder = new PremiumCarComplectation(firstOrderCar);
            CarCompletingDirector firstCompletingDirector = new CarCompletingDirector(premiumBuilder);
            firstCompletingDirector.CompleteCar();
            firstCompletingDirector.ShowResult();
          
            CarComplectation superMegaBuilder = new SuperMegaCarComplectation(secondOrderCar);
            CarCompletingDirector secondCompletingDirector = new CarCompletingDirector(superMegaBuilder);
            secondCompletingDirector.CompleteCar();
            secondCompletingDirector.ShowResult();
        }
    }
}
