using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    public class FactoryDelivery
    {
        public static ITransport GetTransport(TransportType type)
        {
            switch (type)
            {
                case TransportType.Car:
                    return new Car();
                case TransportType.Plane:
                    return new Plane();
                case TransportType.Ship:
                    return new Ship();
                default:
                    throw new NotSupportedException();
            }
        }

        public static string GetAdrerss(string adress)
        {
            return adress;
        }

        public static string GetGoogs(Stone stone)
        {
            return stone.GetName();
        }

        public static void sendTheGoods(string GetTransport, string GetAdrerss,string GetGoogs)
        {
           Console.WriteLine(@$"{GetGoogs} were sent by {GetTransport} at the adress: {GetAdrerss}");
        }

        public enum TransportType
        {
            Car,
            Plane,
            Ship
        }
    }
}
