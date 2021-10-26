using System;

namespace Copart
{
    class Program
    {
        static void Main(string[] args)
        {
            Auctioneer auctioneer = new Auctioneer();

            auctioneer.OnBidChanged += Handler1;
            auctioneer.OnBidChanged += Handler2;
            auctioneer.OnBidChanged += Handler3;

            auctioneer.SetNewBid(50);
            auctioneer.SetNewBid(200);
            auctioneer.SetNewBid(300);
        }

        public static void Handler1(int bidVal)
        {
            if(bidVal > 100)
            {
                Console.WriteLine($"Ohhh they really want to by this car for {bidVal}?");
            }
        }

        public static void Handler2(int bidVal)
        {
            if (bidVal < 300)
            {
                Console.WriteLine($"I can give more, {bidVal} is nothing.");
            }
        }

        public static void Handler3(int bidVal)
        {
            if (bidVal < 200)
            {
                Console.WriteLine($"I will wait a bit. I think that {bidVal} is not the last price.");
            }
        }
    }
}
