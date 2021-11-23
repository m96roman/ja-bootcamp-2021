using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var office = new Office();
            ITransport plane = office.CreateDelivery(DeliveryType.AirShipping);
            ITransport car = office.CreateDelivery(DeliveryType.LandShipping);
            ITransport ship = office.CreateDelivery(DeliveryType.SeaShipping);
            plane.Delivery();
            car.Delivery();
            car.Delivery();
            car.Delivery();
            car.Delivery();
            ship.Delivery();
            ship.Delivery();

        }
    }
}
