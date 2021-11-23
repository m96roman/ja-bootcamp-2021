using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            Direcrtor direcrtor = new Direcrtor();
            var builderA1 = new ConcreteBuilderA1();
            var builderA2 = new ConcreteBuilderA2();
            var builderA5 = new ConcreteBuilderA5();

            direcrtor.Builder = builderA1;

            Console.WriteLine("--------------------------\n");
            direcrtor.BuildSuperMegaProduct();
            Console.WriteLine("--------------------------\n");

            direcrtor.Builder = builderA2;

            Console.WriteLine("--------------------------\n");
            direcrtor.BuildPremiumProduct();
            Console.WriteLine("--------------------------\n");

            //  direcrtor.BuildMinimalProduct();

            // direcrtor.BuildSuperMegaProduct();
            Console.WriteLine("--------------------------\n");




        }
    }
}
