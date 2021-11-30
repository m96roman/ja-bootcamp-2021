using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDedenok_Task6
{
    class Auctioneer
    {
        public Action<int> OnBidChanged;

        public void SetBidWalue(int bidValue)
        {
            OnBidChanged(bidValue);
        }
    }
}
