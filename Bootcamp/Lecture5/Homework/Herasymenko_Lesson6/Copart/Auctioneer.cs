using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copart
{
    class Auctioneer
    {
        public event Action<int> OnBidChanged;
        public static int Bid { get; set; }

        public void SetNewBid(int value)
        {
            Bid = value;
            OnBidChanged?.Invoke(value);
        }

  //      	1. if bidValue > 100,  print "Ohhh they really want to by this car for {bidValue}?", else do nothing
	 // 	2. if bidValue< 300 print "I can give more, {bidValue} is nothing.", else do nothing
		//3. if bidValue< 200 print "I will wait a bit. I think that {bidValue} is not the last price.", else do nothing
    }
}
