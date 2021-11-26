using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Template method */

            Console.WriteLine("---Shop---");
            ShopBuy shop = new ShopBuy();
            shop.PerformBuy();

            Console.WriteLine();
            Console.WriteLine("---Shopping centre---");
            ShoppingCentreBuy shoppingCentre = new ShoppingCentreBuy();
            shoppingCentre.PerformBuy();

            Console.WriteLine();
            Console.WriteLine("---Supermarket---");
            SupermarketBuy supermarket = new SupermarketBuy();
            supermarket.PerformBuy();
        }
    }
}
