using Logistics_Factory.Transportation;

namespace Logistics_Factory.Logistics
{
    class SeaLogisticPlanner : LogisticPlanner
    {
        public override ITransport CreateTransport(string name)
        {
            return new Ship(name);
        }
    }
}
