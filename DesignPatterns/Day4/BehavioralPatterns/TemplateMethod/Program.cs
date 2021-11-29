using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************************");
            Console.WriteLine("Products:");
            var products = new Products();
            products.Shopping();

            Console.WriteLine("********************************");
            Console.WriteLine("Gift:");
            var gift = new Gift();
            gift.Shopping();

            Console.WriteLine("********************************");
            Console.WriteLine("Furniture:");
            var furniture = new Furniture();
            furniture.Shopping();
        }
    }
}
