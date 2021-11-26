using System;
using TeamplateMethod.ShoppingTrips;

namespace TeamplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();

            Console.WriteLine("\n****************");
            Console.WriteLine($"* Buy Products *");
            Console.WriteLine("****************");
            client.ClientShopping(new BuyProducts());

            Console.WriteLine("\n***************");
            Console.WriteLine($"* Buy Present *");
            Console.WriteLine("***************");
            client.ClientShopping(new BuyPresent());

            Console.WriteLine("\n*****************");
            Console.WriteLine($"* Buy Furniture *");
            Console.WriteLine("*****************");
            client.ClientShopping(new BuyFurniture());

        }
    }
}
