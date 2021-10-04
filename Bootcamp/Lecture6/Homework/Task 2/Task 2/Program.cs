using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Auctioneer auctioneer = new Auctioneer();
            auctioneer.OnBidChanged += Auctioneer_OnBidChanged;
            auctioneer.SetNewBid(123);
            
        }

        private static void Auctioneer_OnBidChanged(int obj)
        {
            // 1 

            if (obj > 100)
            {
                Console.WriteLine($"Ohhh they really want to by this car for { obj}?");
            }

            // 2

            if (obj < 300)
            {
                Console.WriteLine($"I can give more, {obj} is nothing.");
            }

            // 3

            if(obj<200)
            {
                Console.WriteLine($"I will wait a bit.I think that { obj } is not the last price.");
            }
            Console.WriteLine(obj);
        }
    }
}
