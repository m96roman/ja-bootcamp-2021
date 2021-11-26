using System;
using ConsoleApp5.Abstracts;
using ConsoleApp5.Captains;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Mediator */

            DispatcherMediator mediator = new DispatcherMediator();

            Captain kyivCaptain = new KyivCaptain(mediator);
            Captain lvivCaptain = new LvivCaptain(mediator);
            Captain uzhhorodCaptain = new UzhhorodCaptain(mediator);

            mediator.KyivShip = kyivCaptain;
            mediator.LvivShip = lvivCaptain;
            mediator.UzhhorodShip = uzhhorodCaptain;

            kyivCaptain.Send("When you are the captain, you find your true friends in stormy weather");
            Console.WriteLine();
            lvivCaptain.Send("Sailing on a bad ship with a good captain is preferable");
            Console.WriteLine();
            uzhhorodCaptain.Send("It's imperative to control the wheel of your own ship");
        }
    }
}
