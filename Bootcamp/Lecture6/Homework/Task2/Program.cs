using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Auctioner auction = new Auctioner();

            auction.OnBitAction += PrintResult100;
            auction.OnBitAction += PrintResult200;
            auction.OnBitAction += PrintResult300;

            auction.SetNewBid(50);
            auction.SetNewBid(150);
            auction.SetNewBid(250);
        }

        static void PrintResult100(int bidValue)
        {
            if (bidValue > 100)
            {
                Console.WriteLine($"Ohhh they really want to by this car for {bidValue}?");
            }
        }
        static void PrintResult200(int bidValue)
        {
            if (bidValue < 200)
            {
                Console.WriteLine($"I can give more, {bidValue} is nothing.");
            }
        }
        static void PrintResult300(int bidValue)
        {
            if (bidValue < 300)
            {
                Console.WriteLine($"I will wait a bit. I think that {bidValue} is not the last price.");
            }
        }
    }
}
