using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public abstract class AbstractOfficeFactory
    {
        protected abstract ITransport NewShipDelivery();
        protected abstract ITransport NewPlaneDelivery();
        protected abstract ITransport NewTruckDelivery();
        public abstract void DeliverAllGoods();

    }
}
