using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIvanyshyn_6.Auctioneer
{
    class Auctioneer
    {
        public Auctioneer() : this(1)
        {
        }

        public Auctioneer(double currentBid)
        {
            CurrentBid = currentBid;
        }

        public double CurrentBid { get; private set; }

        /// <summary>
        /// Activates on bid changed
        /// </summary>
        public event Action<double> OnBidChanged;

        /// <summary>
        /// Sets new bid and calls <see cref="Action<double,double>"/>
        /// </summary>
        /// <param name="newBid"></param>
        public void SetNewBid(double newBid)
        {
            var oldBid = CurrentBid;
            CurrentBid = newBid;
            OnBidChanged?.Invoke(newBid);
        }
    }
}
