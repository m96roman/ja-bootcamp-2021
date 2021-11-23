using Goods;
using Logistics_Factory.Transportation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logistics_Factory.Logistics
{
    abstract class LogisticPlanner
    {
        public void PlanDelivery(string destination, IGood good, string number)
        {
            ITransport transport = CreateTransport(number);
            transport.DeliverTo(destination, good);
        }

        public abstract ITransport CreateTransport(string name);
    }
}
