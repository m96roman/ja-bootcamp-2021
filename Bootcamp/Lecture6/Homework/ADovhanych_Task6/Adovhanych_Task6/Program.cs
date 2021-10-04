using System;

namespace Adovhanych_Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            var auctioneer = new Auctioneer();
            var lowValue = new BidValueLow();
            var mediumValue = new BidValueMedium();
            var highValue = new BidValueHigh();

            auctioneer.OnBidChanged += lowValue.Message;
            auctioneer.OnBidChanged += mediumValue.Message;
            auctioneer.OnBidChanged += highValue.Message;

            auctioneer.SetNewBid(20);
            
        }
    }
}
