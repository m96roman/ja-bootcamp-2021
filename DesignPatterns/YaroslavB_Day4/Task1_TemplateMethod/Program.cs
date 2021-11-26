using System;

namespace Task1_TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Going for foods:");
            GoShoppingTemplate shopping = new BuyFoods();
            shopping.GoShopping();

            Console.WriteLine("\n\nGoing for some present:");
            shopping = new BuyPresent();
            shopping.GoShopping();

            Console.WriteLine("\n\nGoing for furniture:");
            shopping = new BuyFurniture();
            shopping.GoShopping();

            Console.WriteLine("\n\nPress \'Enter\' to exit...");
            Console.ReadLine();
        }
    }
}
