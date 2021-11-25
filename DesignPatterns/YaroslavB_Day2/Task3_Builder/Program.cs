using System;

namespace Task3_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ordering car A2 premium...");

            BuilderModelA2 builderA2 = new BuilderModelA2();
            Director director = new Director(builderA2);
            director.ConstructPremiumConfiguration();
            CarModelA2 carA2 = builderA2.GetResult();

            Console.WriteLine($"Ordered: car {carA2.ModelName} {director.Configuration}");



            Console.WriteLine("\n\nOrdering car A1 super mega...");

            BuilderModelA1 builderA1 = new BuilderModelA1();
            director = new Director(builderA1);
            director.ConstructSuperMegaConfiguration();
            CarModelA1 carA1 = builderA1.GetResult();

            Console.WriteLine($"Ordered: car {carA1.ModelName} {director.Configuration}");


            Console.WriteLine("\n\nPress \'Enter\' to exit...");
            Console.ReadLine();
        }
    }
}
