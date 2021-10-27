using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDedenok_Task6
{
    public class BitMonitorer2
    {
        public void MonitoringBids2(int bidValue)
        {
            const int val = 300;
            if (bidValue < val)
            {
                Console.WriteLine($"I can give more, {bidValue} is nothing.");
            }
        }
    }
}
