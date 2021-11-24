using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class OfficeCreatorFactory : AbstractOfficeFactory
    {
        protected override ITransport NewShipDelivery() {
            ITransport ship = new ShipDelivery();
            ship.Deliver("stones 1st cargo", "Turkey");
            ship.Deliver("stones 2st cargo", "Bulgary");
            return ship;
        }
        protected override ITransport NewPlaneDelivery()
        {
            ITransport plane = new PlaneDelivery();
            plane.Deliver("stones 1st cargo", "Germany");
            return plane;
        }
        protected override ITransport NewTruckDelivery()
        {
            ITransport truck = new TruckDelivery();
            truck.Deliver("stones 1st cargo", "Lviv");
            truck.Deliver("stones 2st cargo", "Uzhgorod");
            truck.Deliver("stones 3st cargo", "Kyiv");
            truck.Deliver("stones 4th cargo", "Odessa");
            return truck;
        }

        public override void DeliverAllGoods()
        {
            NewShipDelivery();
            NewPlaneDelivery();
            NewTruckDelivery();
        }
    }
}
