using Mediator.Ships;
using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var despetcher = new Despetcher();

            var shipUzh = new UzhgorodShip(despetcher);
            var shipLviv = new LvivShip(despetcher);
            var shipKiev = new KievShip(despetcher);

            despetcher.AddShip(shipKiev);
            despetcher.AddShip(shipUzh);
            despetcher.AddShip(shipLviv);

            shipUzh.SendMassege("Hello World", "LvivShip");
        }
    }
}
