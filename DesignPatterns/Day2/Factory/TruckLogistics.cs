using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class TruckLogistics : Logistics
    {
        public override ITransport GetTransport()
        {
            return new Truck();
        }
    }
}
