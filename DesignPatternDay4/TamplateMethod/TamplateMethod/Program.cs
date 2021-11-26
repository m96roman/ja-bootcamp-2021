using System;

namespace TamplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            DoShopping buyFood = new GoToSupermarket();
            buyFood.DoShoppingNow();
           
            Console.WriteLine("----------------------");
            DoShopping buyPresent = new BuyPresent();
            buyPresent.DoShoppingNow();

            Console.WriteLine("----------------------");
            DoShopping buyFurniture = new BuyFurniture();
            buyFurniture.DoShoppingNow();

        }
    }
}
