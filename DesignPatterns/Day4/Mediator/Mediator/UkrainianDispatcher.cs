using System;
using System.Collections.Generic;

namespace Mediator
{
    class UkrainianDispatcher : IDispatcher
    {
        public List<INavigable> Ships { get; private set; }

        public UkrainianDispatcher(List<INavigable> ships)
        {
            ships.ForEach(i => i.SetMediator(this));
            this.Ships = ships;
        }

        public void Notify(object sender, string receiverName, string message)
        {
            var senderShip = (Ship)sender;

            Console.WriteLine($"{senderShip.Name} needs say {message} to {receiverName}");

            var ship = Ships.Find(p => p.Name == receiverName);

            ship.Maneuver(message);
        }
    }
}
