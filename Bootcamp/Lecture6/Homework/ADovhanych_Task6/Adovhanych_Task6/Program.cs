using System;
using System.Collections.Generic;

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

            auctioneer.SetNewBid(250);

            Console.WriteLine("___________________________");

            List<string> testList = new List<string>() { "Abc", "Def", "ghjkl" };

            var testFilter = testList.Filter(FilterExtension.FilterFunction);
            var testMap = testList.Map(MapExtension.MapFilter);

            foreach (var item in testFilter)
            {
                Console.WriteLine(item);
            }
        }
    }
}
