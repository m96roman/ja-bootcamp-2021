using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var stone = FactoryDelivery.GetGoogs(new Stone() { StoneName = "Good1" });
            var adress = FactoryDelivery.GetAdrerss("Adress1");
            var transportCar =FactoryDelivery.GetTransport(FactoryDelivery.TransportType.Car).GetName();
            var transportPlane = FactoryDelivery.GetTransport(FactoryDelivery.TransportType.Plane).GetName();
            var transportShip = FactoryDelivery.GetTransport(FactoryDelivery.TransportType.Ship).GetName();

            FactoryDelivery.sendTheGoods(transportCar, adress, stone);
            FactoryDelivery.sendTheGoods(transportCar, adress, stone);
            FactoryDelivery.sendTheGoods(transportCar, adress, stone);
            FactoryDelivery.sendTheGoods(transportCar, adress, stone);
            FactoryDelivery.sendTheGoods(transportPlane, adress, stone);
            FactoryDelivery.sendTheGoods(transportShip, adress, stone);
            FactoryDelivery.sendTheGoods(transportShip, adress, stone);
        }
    }
}
