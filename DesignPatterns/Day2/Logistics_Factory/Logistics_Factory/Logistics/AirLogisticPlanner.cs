using Logistics_Factory.Transportation;

namespace Logistics_Factory.Logistics
{
    class AirLogisticPlanner : LogisticPlanner
    {
        public override ITransport CreateTransport(string name)
        {
            return new Plane(name);
        }
    }
}
