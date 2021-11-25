using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDedenok_Task6
{
    public class BitMonitorer3
    {
        public void MonitoringBids3(int bidValue)
        {
            const int val = 200;
            if (bidValue < val)
            {
                Console.WriteLine($"I will wait a bit. I think that {bidValue} is not the last price.");
            }
        }
    }
}
