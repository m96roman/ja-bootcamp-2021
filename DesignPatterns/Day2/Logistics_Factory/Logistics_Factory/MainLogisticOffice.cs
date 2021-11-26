using Goods;
using Logistics_Factory.Logistics;
using System;

namespace Logistics_Factory
{
    internal class MainLogisticOffice
    {
        public MainLogisticOffice()
        {
        }

        internal void DeliverBySea(string destination, IGood stone)
        {
            LogisticPlanner logisticPlanner = new SeaLogisticPlanner();

            logisticPlanner.PlanDelivery(destination, stone, "1");
        }

        internal void DeliverByLand(string destination, IGood stone)
        {
            LogisticPlanner logisticPlanner = new RoadLogisticPlanner();

            logisticPlanner.PlanDelivery(destination, stone, "2");
        }

        internal void DeliverByAir(string destination, IGood stone)
        {
            LogisticPlanner logisticPlanner = new RoadLogisticPlanner();

            logisticPlanner.PlanDelivery(destination, stone, "");
        }
    }
}