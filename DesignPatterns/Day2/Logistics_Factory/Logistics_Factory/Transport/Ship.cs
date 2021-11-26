using Goods;

namespace Logistics_Factory.Transportation
{
    internal class Ship : Transport
    {
        public Ship(string name) : base(name)
        {
        }

        public override void DeliverTo(string destination, IGood good)
        {
            System.Console.WriteLine("Delivering by sea...");
            base.DeliverTo(destination, good);
        }
    }
}
