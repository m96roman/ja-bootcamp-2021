using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedakTask6
{
    public class Auctioneer
    {
        public int Bid { get; set; }

        public event Action<int> OnBidChanged;

        public Auctioneer(int bid)
        {
            this.Bid = bid;
        }

        public void SetNewBid(int number)
        {
            var oldBid = Bid;
            Bid = number;
            OnBidChanged?.Invoke(number);
        }
    }
}
