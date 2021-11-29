using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Desptcher : Mediator
    {
        public List<Ship> Ships = new List<Ship>();

        public override void Send(string msg, Ship ship, string nameTo)
        {
            ship.Notify(msg, nameTo);
            Ships.Find(s => s.Name == nameTo).Receive();
        }
    }
}
