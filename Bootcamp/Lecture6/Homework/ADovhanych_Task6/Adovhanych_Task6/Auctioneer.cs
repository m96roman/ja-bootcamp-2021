using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adovhanych_Task6
{
    class Auctioneer
    {
        //public int BidValue { get; set; }

        public event Action<int> OnBidChanged;

        public void SetNewBid(int bidValue)
        {
            if (bidValue > 0)
            {
                OnBidChanged?.Invoke(bidValue);
            } 
        }
    }
}
