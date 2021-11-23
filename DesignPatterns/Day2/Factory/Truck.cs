using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Truck:ITransport
    {
        public string Delivery()
        {
           return "deliver by truck";
        }
    }
}
