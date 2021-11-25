using System;

namespace Task1_FactoryMethod
{
    class Program
    {
        //ITransport - product
        //Truck, Ship, Aircraft - Concrete Product
        //LogisticCompany - Creator 
        //OverlandLogisticCompany, SeaLogisticCompany, AircraftLogisticCompany - Concrete Creator 

        static void Main(string[] args)
        {
            LogisticCompany carDelivery = new OverlandLogisticCompany();
            LogisticCompany seaDelivery = new SeaLogisticCompany();
            LogisticCompany airDelivery = new AircraftLogisticCompany();

            //sending by ship
            seaDelivery.Deliver("Turkey, Antalya, Dock-6", "Stones");
            seaDelivery.Deliver("Egypt, Alexandria, Dock-1", "Stones");

            Console.WriteLine();

            //sending by plane
            airDelivery.Deliver("Canada, Toronto, AirPort Warehouse-2", "Stones");

            Console.WriteLine();

            //sending by car
            carDelivery.Deliver("Ukraine, Lviv, Warehouse-4", "Stones");
            carDelivery.Deliver("Ukraine, Uzhgorod, Warehouse-1", "Stones");
            carDelivery.Deliver("Ukraine, Kyiv, Warehouse-3", "Stones");
            carDelivery.Deliver("Ukraine, Odessa, Dock-2", "Stones");

            Console.WriteLine("\n\nPress \'Enter\' to exit...");
            Console.ReadLine();
        }
    }
}
