using System;

namespace Logistics_Factory.Transportation
{
    abstract class Transport : ITransport
    {
        protected Transport(string number)
        {
            TransportNumber = number;
        }

        public string TransportNumber { get; set; }

        public virtual void DeliverTo(string destination, Goods.IGood good)
        {
            Console.WriteLine($"Transport with name {TransportNumber} arrive to {destination} with good {good.Name}");
        }
    }
}
