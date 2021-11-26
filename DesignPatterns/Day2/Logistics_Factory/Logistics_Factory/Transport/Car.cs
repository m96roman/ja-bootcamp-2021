using Goods;

namespace Logistics_Factory.Transportation
{
    class Car : Transport
    {
        public Car(string name) : base(name)
        {
        }

        public override void DeliverTo(string destination, IGood good)
        {
            System.Console.WriteLine("Delivering by land....");

            base.DeliverTo(destination, good);
        }
    }
}
