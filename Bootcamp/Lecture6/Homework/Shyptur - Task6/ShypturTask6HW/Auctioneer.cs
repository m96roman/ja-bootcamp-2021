﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShypturTask6HW
{
    public class Auctioneer
    {
        public event Action<int> OnBidChanged;

        public void SetNewBid(int value)
        {
            OnBidChanged?.Invoke(value);
        }
    }
    public class Bid
    {
        public void Wanttoby(int bidValue)
        {
            if (bidValue > 100)
            {
                Console.WriteLine($"Ohhh they really want to by this car for {bidValue}?");
            }
        }

        public void Givemore(int bidValue)
        {
            if (bidValue < 200)
            {
                Console.WriteLine($"I can give more, {bidValue} is nothing.");
            }
        }

        public void Willwait(int bidValue)
        {
            if (bidValue < 300)
            {
                Console.WriteLine($"I will wait a bit. I think that {bidValue} is not the last price.");
            }
        }
    }
}
