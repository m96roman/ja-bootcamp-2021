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

            List<string> testList = new() { "Abc", "Def", "ghjkl" };
            List<int> intList = new() { 1, 2, 3 };

            ICollection<string> testFilter = testList.Filter(str => char.IsUpper(str[0]));
            ICollection<int> testMap = testList.Map(str => str.Length);
            ICollection<string> testGenFilter = testList.GenFilter(str => str.Length > 3);
            ICollection<int> testGenMap = intList.GenMap(number => number > 2);

            foreach (var item in testGenMap)
            {
                Console.WriteLine(item);
            }
        }
    }
}
