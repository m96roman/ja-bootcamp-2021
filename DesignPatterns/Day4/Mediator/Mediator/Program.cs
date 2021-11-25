using System;
using System.Collections.Generic;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {

            Ship ship1 = new Ship
            {
                Name = "Lviv"
            };

            Ship ship2 = new Ship
            {
                Name = "Uzhorod"
            };

            Ship ship3 = new Ship
            {
                Name = "Kyiv"
            };


            UkrainianDispatcher ukrainianDispatcher = new UkrainianDispatcher(new List<INavigable> {
               ship1,
               ship2,
               ship3
            });

            ship1.Dispatcher.Notify(ship1, "Kyiv", "move out dumbass");
            ship3.Dispatcher.Notify(ship2, "Lviv", "move right please");
            ship3.Dispatcher.Notify(ship3, "Uzhorod", "move left please");
        }
    }
}
