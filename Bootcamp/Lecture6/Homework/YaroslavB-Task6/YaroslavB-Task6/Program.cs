using System;
using System.Collections.Generic;

namespace YaroslavB_Task6
{
    class Program
    {
        static void Main(string[] args)
        {

            UseExtension();

            Console.WriteLine("\n\nPress \'Enter\' to go to Events");
            Console.ReadLine();

            UseEvents();

            Console.WriteLine("\n\nPress \'Enter\' to exit");
            Console.ReadLine();
        }

        private static void UseExtension()
        {
            Console.WriteLine("=============== Using extension method \"Filter\" ==================================\n" +
                              "=============== to get a collection of strings with specified length =============\n");

            ICollection<string> collection = new string[] { "name", "no", "Italy", "red", "Tom", "monitor", "true", "ok", "Denver", "Jane" };
            var tempResult = collection.Filter(s => s.Length < 5);
            Console.WriteLine("Strings with length < 5");

            foreach (var item in tempResult)
            {
                Console.WriteLine(" " + item);
            }

            Console.WriteLine("\n\n=========== Using extension method \"Map\" to transform string to int ===============\n" +
                                  "=========== *getting length of each string item in the collection =================\n");

            var tempInts = collection.Map(s => s.Length);
            Console.WriteLine("Length of each item:");

            foreach (var item in tempInts)
            {
                Console.WriteLine(" " + item);
            }


            Console.WriteLine("\n\n========== Using extension methods \"Filter\" and \"Map\" to filter elements ==========\n" +
                                  "========== which start from uppercase and get those elements length ===============\n");

            var tempStrs = collection.Filter(s => char.IsUpper(s[0]))
                                     .Map(s => s.Length);

            Console.WriteLine("Length of elements which start from uppercase:");

            foreach (var item in tempStrs)
            {
                Console.WriteLine(" " + item);
            }

            Console.WriteLine("\n\n========== Own example of usage extension generic method \"Map\" ==========\n" +
                                  "========== to get the first char of each of elements ====================\n");
            var tempChr = collection.Map(s => s[0]);
            Console.WriteLine("First character of elemets:");

            foreach (var item in tempChr)
            {
                Console.WriteLine(" " + item);
            }
        }

        private static void UseEvents()
        {
            List<Bidder> bidders = new List<Bidder>
            {
                new Bidder(v => v > 100, "Ohhh they really want to by this car for {bidValue}?"),
                new Bidder(v => v < 300, "I can give more, {bidValue} is nothing."),
                new Bidder(v => v < 200, "I will wait a bit. I think that {bidValue} is not the last price.")
            };

            var auctioneer = new Auctioneer();

            foreach (var bidder in bidders)
            {
                auctioneer.OnBidChanged += bidder.CheckNewBidValue;
            }

            for (int i = 50; i <= 250; i += 100)
            {
                Console.WriteLine("\nPress \'Enter\' to set new value!");
                Console.ReadLine();
                Console.WriteLine($"Setting bid - {i}...");
                auctioneer.SetNewBid(i);
                Console.WriteLine();
            }
        }
    }
}
