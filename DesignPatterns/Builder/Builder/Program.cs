using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var builderA1 = new BuildModelA1();
            var builderA2 = new BuildModelA2();

            director.Builder = builderA1;
            director.BasicModel();

            director.Builder = builderA2;
            director.PremiumModel();

            Console.ReadLine();

        }
    }
}
