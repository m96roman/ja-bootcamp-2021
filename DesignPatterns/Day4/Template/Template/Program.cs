using System;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            IShoppingAlgorithm shoppingAlgorithm = new ProductAlgorighm();

            shoppingAlgorithm.ExecuteShopping("bread");

            Console.WriteLine(new string('-', 20));

            shoppingAlgorithm = new PresentsAlgorithm();

            shoppingAlgorithm.ExecuteShopping("teddy bear");

            Console.WriteLine(new string('-', 20));

            shoppingAlgorithm = new FurnitureAlgorithm();

            shoppingAlgorithm.ExecuteShopping("something");
        }
    }
}
