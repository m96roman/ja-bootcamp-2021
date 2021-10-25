using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRoshko_Task6
{
    public delegate void Notify(object arg,int bid);
    class Auctioneer
    {
        private int Bid { get; set; }

        public event Notify OnBidChanged;

        public void SetNewBid(int argument)
        {
            Bid = argument;

            Notify handler = OnBidChanged;

            handler?.Invoke(this,argument);
        }
    }
}
