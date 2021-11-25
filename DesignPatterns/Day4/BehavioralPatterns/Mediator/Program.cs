using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {

            Desptcher sDesptcher = new Desptcher();
            var lvivShip = new LvivShip(sDesptcher);
            var kievShip = new KievShip(sDesptcher);
            var uzhorodShip = new UzhorodShip(sDesptcher);

            sDesptcher.KievShip = kievShip;
            sDesptcher.LvivShip = lvivShip;
            sDesptcher.UzhhorodShip = uzhorodShip;
            sDesptcher.Ships.Add(lvivShip);
            sDesptcher.Ships.Add(kievShip);
            sDesptcher.Ships.Add(uzhorodShip);

            kievShip.Send("Hi my friend",lvivShip.Name);
            lvivShip.Send("Heloooooooo",kievShip.Name);
            uzhorodShip.Send("I am here", kievShip.Name);
            kievShip.Send("I see",uzhorodShip.Name);

        }
    }
}
