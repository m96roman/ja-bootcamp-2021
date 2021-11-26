using Goods;

namespace Logistics_Factory.Transportation
{
    interface ITransport
    {
        public string TransportNumber { get; set; }

        void DeliverTo(string destination, IGood good);
    }
}
