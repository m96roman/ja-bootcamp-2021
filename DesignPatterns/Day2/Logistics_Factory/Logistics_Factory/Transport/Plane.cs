using Goods;

namespace Logistics_Factory.Transportation
{
    internal class Plane : Transport
    {
        public Plane(string name) : base(name)
        {
        }

        public override void DeliverTo(string destination, IGood good)
        {
            System.Console.WriteLine("Delivering by air...");

            base.DeliverTo(destination, good);
        }
    }
}
