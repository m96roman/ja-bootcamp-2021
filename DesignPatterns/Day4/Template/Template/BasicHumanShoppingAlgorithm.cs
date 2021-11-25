using System;

namespace Template
{
    abstract class BasicHumanShoppingAlgorithm : IShoppingAlgorithm
    {
        public void ExecuteShopping(string product)
        {
            ArriveToDestination(product);

            Prepare(product);

            Choose(product);

            Buy(product);

            TakeHome(product);
        }

        protected virtual void Choose(string product)
        {
            Console.WriteLine($"Choose neded {product}");
        }

        protected virtual void TakeHome(string product)
        {
            Console.WriteLine($"Take {product} by car to home");
        }

        protected virtual void ArriveToDestination(string product)
        {

        }


        protected virtual void Prepare(string product) { }

        protected virtual void Buy(string product)
        {
            Console.WriteLine($"Pay for {product} through card");
        }

    }
}
