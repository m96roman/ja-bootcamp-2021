using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Auctioneer auctioneer = new Auctioneer();
            auctioneer.OnBidChanged += Auctioneer_OnBidChanged_1;
            auctioneer.OnBidChanged += Auctioneer_OnBidChanged_2;
            auctioneer.OnBidChanged += Auctioneer_OnBidChanged_3;
            auctioneer.SetNewBid(123);
        }

        private static void Auctioneer_OnBidChanged_1(int obj)
        {
            if (obj > 100)
            {
                Console.WriteLine($"Ohhh they really want to by this car for { obj}?");
            }
        }

        private static void Auctioneer_OnBidChanged_2(int obj)
        {
            if (obj < 300)
            {
                Console.WriteLine($"I can give more, {obj} is nothing.");
            }
        }
        
        private static void Auctioneer_OnBidChanged_3(int obj)
        { 
            if(obj<200)
            {
                Console.WriteLine($"I will wait a bit.I think that { obj } is not the last price.");
            }
            Console.WriteLine(obj);
        }
    }
}
