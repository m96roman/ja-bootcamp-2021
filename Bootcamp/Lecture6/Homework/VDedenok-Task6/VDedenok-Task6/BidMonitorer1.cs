using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDedenok_Task6
{
    class BitMonitorer1
    {
        public void MonitoringBids1(int bidValue)
        {
            const int val = 100;

            if (bidValue > val)
            {
                Console.WriteLine($"Ohhh they really want to by this car for {bidValue}?");
            }
        }
    }
}
