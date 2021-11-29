using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {

            Desptcher sDesptcher = new Desptcher();
            sDesptcher.Ships.Add(new LvivShip(sDesptcher));
            sDesptcher.Ships.Add(new KievShip(sDesptcher));
            sDesptcher.Ships.Add(new UzhorodShip(sDesptcher));

            sDesptcher.Ships.Find(s => s.Name == "Kiev").Send("Hello Lviv!","Lviv");
            sDesptcher.Ships.Find(s => s.Name == "Lviv").Send("OH! Hi Kiev!", "Kiev");
            sDesptcher.Ships.Find(s => s.Name == "Uzhorod").Send("I see you!", "Lviv");
        }
    }
}
