using Logistics_Factory.Transportation;

namespace Logistics_Factory.Logistics
{
    class RoadLogisticPlanner : LogisticPlanner
    {
        public override ITransport CreateTransport(string name)
        {
            return new Car(name);
        }
    }
}
