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

        public static Stone GetGoogs(Stone stone)
        {
            Console.WriteLine(stone.GetName());
            return stone;
        }

        public static Stone sendTheGoods(string GetTransport, string GetAdrerss,Stone GetGoogs)
        {
           Console.WriteLine(@$"{GetGoogs.GetName()} were sent by {GetTransport} at the adress: {GetAdrerss}");
            return GetGoogs;
        }

        public enum TransportType
        {
            Car,
            Plane,
            Ship
        }
    }
}
