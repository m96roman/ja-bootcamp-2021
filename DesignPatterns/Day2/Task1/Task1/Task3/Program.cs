using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            ICarComponents a1 = new CarModelA1();
            director.carComponents = a1;
            director.CreateMinimalProduct();

            ICarComponents a2 = new CarModelA2();
            director.carComponents = a2;
            director.CreatePremiumProduct();

            ICarComponents a3 = new CarModelA3();
            director.carComponents = a3;
            director.CreateSuperMegaProduct();
        }
    }
}
