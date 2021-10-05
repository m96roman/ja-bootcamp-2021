using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIvanyshyn_6.Auctioneer
{
    internal class Task2
    {
        public static void Execute()
        {
            Auctioneer auctioneer = new Auctioneer(50);

            auctioneer.OnBidChanged += Auctioneer_OnBidChanged;
            auctioneer.OnBidChanged += Auctioneer_OnBidChanged1;
            auctioneer.OnBidChanged += Auctioneer_OnBidChanged2;

            for (int i = 1; i <= 5; i++)
            {
                auctioneer.SetNewBid(auctioneer.CurrentBid * i);
                Console.WriteLine(new string('-', 20));
            }
        }

        private static void Auctioneer_OnBidChanged2(double bidValue)
        {
            if (bidValue < 200)
            {
                Console.WriteLine($"I will wait a bit. I think that {bidValue} is not the last price.");
            }
        }

        private static void Auctioneer_OnBidChanged1(double bidValue)
        {
            if (bidValue < 300)
            {
                Console.WriteLine($"I can give more, {bidValue} is nothing.");
            }
        }

        private static void Auctioneer_OnBidChanged(double bidValue)
        {
            if (bidValue > 100)
            {
                Console.WriteLine($"Ohhh they really want to by this car for {bidValue}?");
            }
        }
    }
}
