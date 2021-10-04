using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adovhanych_Task6
{
    class BidValueHigh
    {
        public void Message(int bidValue)
        {
            if (bidValue < 300)
            {
                Console.WriteLine($"I can give more, {bidValue} is nothing.");
            }
        } 
    }
}
