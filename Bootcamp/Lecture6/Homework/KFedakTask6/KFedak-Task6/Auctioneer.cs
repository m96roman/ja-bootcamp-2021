using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedak_Task6
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
            Bid = number;
            OnBidChanged?.Invoke(number);
        }
    }
}
