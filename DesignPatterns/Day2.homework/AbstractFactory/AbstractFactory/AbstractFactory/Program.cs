using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductB product = new ProductB();
            var modelB = new ModelB();
            modelB.addAllPartsTogether(product);

            Console.WriteLine("s");
        }
    }
}
