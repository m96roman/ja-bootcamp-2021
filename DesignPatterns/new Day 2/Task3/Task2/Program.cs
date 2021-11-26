using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder builder = new Builder();
            CarBuilder carBuilderA1 = new A1CarBuilder();
            Car carA1 = builder.Build(carBuilderA1);

            CarBuilder carBuilderA2 = new A2CarBuilder();
            Car carA2 = builder.Build(carBuilderA2);

            Console.WriteLine(carA1);
            Console.WriteLine(carA2);
        }
    }
}
