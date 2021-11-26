using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            KyivShip kyivShip = new KyivShip();
            LvivShip lvivShip = new LvivShip();
            UzhShip uzhShip = new UzhShip();
            Operator operator1 = new Operator(uzhShip, lvivShip, kyivShip);

            operator1.Notify(uzhShip);
            Console.WriteLine();
            operator1.Notify(lvivShip);
            Console.WriteLine();
            operator1.Notify(kyivShip);
        }
    }
}
