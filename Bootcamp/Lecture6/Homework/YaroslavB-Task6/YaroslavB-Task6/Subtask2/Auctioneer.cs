using System;

namespace YaroslavB_Task6
{
    class Auctioneer
    {
        public event EventHandler<int> OnBidChanged;

        public int BidValue { get; set; }

        public void SetNewBid(int value)
        {
            Console.WriteLine($"New bid is set at - {value}");
            OnBidChanged?.Invoke(this, value);
        }
    }
}
