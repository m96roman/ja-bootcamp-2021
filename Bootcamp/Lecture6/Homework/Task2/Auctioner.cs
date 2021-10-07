using System;

namespace Task2
{
    public class Auctioner
    {
        public delegate void OnBidChanged(object sender, AuctionEventArgs e);

        public event Action<int> OnBitAction;

        public void SetNewBid(int bidValue)
        {
            OnBitAction?.Invoke(bidValue);
        }
    }
}
