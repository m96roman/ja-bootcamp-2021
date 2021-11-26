using System;
using ConsoleApp3.Builders;
using ConsoleApp3.Enums;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Diller diller = new Diller();

            CarBuilder builder = new PremiumCarBuilder();
            builder.CarModel = CarModels.A2;

            Car a2Premium = diller.Deliver(builder);

            Console.WriteLine(a2Premium.ToString());

            builder = new SuperMegaCarBuilder();
            builder.CarModel = CarModels.A1;

            Car a1SuperMega = diller.Deliver(builder);

            Console.WriteLine(a1SuperMega.ToString());
        }
    }
}
