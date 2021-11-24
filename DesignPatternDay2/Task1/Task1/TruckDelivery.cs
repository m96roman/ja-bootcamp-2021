using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class TruckDelivery : ITransport
    {
        public void Deliver(string goods, string adress)
        {
            Console.WriteLine($"The {goods} is delivered by truck to {adress}.");
        }
    }
}
