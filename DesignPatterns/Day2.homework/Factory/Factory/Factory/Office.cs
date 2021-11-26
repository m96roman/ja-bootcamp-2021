using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Office
    {
        public ITransport CreateDelivery(DeliveryType deliveryType)
        {
            switch (deliveryType)
            {
                case DeliveryType.AirShipping:
                    return new Plane();
                case DeliveryType.LandShipping:
                    return new Car();
                case DeliveryType.SeaShipping:
                    return new Ship();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
