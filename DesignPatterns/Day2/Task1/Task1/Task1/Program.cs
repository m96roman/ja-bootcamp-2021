using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stone stone = new Stone(1.2, 0.5, 1, "Ucraine, Uzhgorod");

            ILogistics logistics = new WaterLogistics();
            ITransport transport = logistics.CreateTransport();
            transport.Deilver(stone);
            transport.Deilver(stone);
            Console.WriteLine();

            logistics = new FlyLogistics();
            transport = logistics.CreateTransport();
            transport.Deilver(stone);
            Console.WriteLine();

            logistics = new RoadLogistics();
            transport = logistics.CreateTransport();
            transport.Deilver(stone);
            transport.Deilver(stone);
            transport.Deilver(stone);
            transport.Deilver(stone);

        }
    }
}
