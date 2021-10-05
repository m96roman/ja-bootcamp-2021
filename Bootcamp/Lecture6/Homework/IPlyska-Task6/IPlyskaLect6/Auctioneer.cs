using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPlyskaLect6
{
    public class Auctioneer
    {
        public event Action<int> OnBidChanged;

        public void SetNewBid(int input)
        {
            OnBidChanged?.Invoke(input);
        }
    }

    public class HandlerWithFirst
    {
        public void HandleSetNewBidWith(int input)
        {
            if (input > 100)
            {
                Console.WriteLine($"Ohhh they really want to by this car for {input}?");
            }
        }
    }

    public class HandlerWithSecond
    {
        public void HandleSetNewBidWith(int input)
        {
            if (input < 200)
            {
                Console.WriteLine($"I will wait a bit. I think that {input} is not the last price.");
            }
        }
    }

    public class HandlerWithThird
    {
        public void HandleSetNewBidWith(int input)
        {
            if (input < 300)
            {
                Console.WriteLine($"I can give more, {input} is nothing.");
            }
        }
    }
}
