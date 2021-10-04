using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adovhanych_Task6
{
    class BidValueMedium
    {
        public void Message(int bidValue)
        {
            if (bidValue < 200)
            {
                Console.WriteLine($"I will wait a bit.I think that { bidValue} is not the last price.");
            }
        }
    }
}
