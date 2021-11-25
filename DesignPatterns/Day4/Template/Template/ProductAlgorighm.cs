using System;

namespace Template
{
    class ProductAlgorighm : BasicHumanShoppingAlgorithm
    {

        protected override void ArriveToDestination(string product)
        {
            Console.WriteLine("Walk from work");
            Console.WriteLine($"Arrive to shop to buy {product}");
        }

        protected override void Choose(string product)
        {
            Console.WriteLine($"Walk with clever face, through stellages");
            base.Choose(product);
        }

        protected override void Prepare(string product)
        {
            Console.WriteLine($"Take bascet for {product}");
        }

    }
}
