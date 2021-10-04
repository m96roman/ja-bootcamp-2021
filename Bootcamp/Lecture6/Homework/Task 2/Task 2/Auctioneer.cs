using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    public class Auctioneer
    {

        public int Bid { get; private set; }
        public event Action<int> OnBidChanged;

        public void SetNewBid(int num)
        {
            Bid = num;
            OnBidChanged?.Invoke(Bid);
            Bid = 4;
            OnBidChanged?.Invoke(Bid);
            Bid = 400;
            OnBidChanged?.Invoke(Bid);
            Bid = 200;
            OnBidChanged?.Invoke(Bid);
        }
    }

    class Auctioneer1
    {


    }
}
