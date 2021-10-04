using System;

namespace KFedakTask6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task1\n");

            string[] text = "Magic winter Summer party".Split(" ");

            var collectionOfWords = text.Filter(x => char.IsUpper(x[0]));

            var countOfWord = collectionOfWords.Map(x => x.Length);

            Console.WriteLine(string.Join(" ", collectionOfWords));

            Console.WriteLine(string.Join(" ", countOfWord));

            Console.WriteLine("Task2\n");

            Auctioneer auctioneer = new Auctioneer(25);

            auctioneer.OnBidChanged += ActionOne;
            auctioneer.OnBidChanged += ActionTwo;
            auctioneer.OnBidChanged += ActionThree;

            for (int i = 1; i <= 400; i += 100)
            {
                auctioneer.SetNewBid(auctioneer.Bid + i);

                Console.WriteLine("*******************************************\n");
            }
        }

        private static void ActionOne(int bid)
        {
            if (bid > 100)
            {
                Console.WriteLine($"Ohhh they really want to by this car for {bid}?");
            }
        }

        private static void ActionTwo(int bid)
        {
            if (bid < 300)
            {
                Console.WriteLine($"I can give more, {bid} is nothing.");
            }
        }

        private static void ActionThree(int bid)
        {
            if (bid < 200)
            {
                Console.WriteLine($"I will wait a bit. I think that {bid} is not the last price.");
            }
        }
    }
}
