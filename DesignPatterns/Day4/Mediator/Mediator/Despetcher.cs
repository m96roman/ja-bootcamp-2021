using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Despetcher : IMediator
    {
        private List<Ship> ships = new List<Ship>();

        public void AddShip(Ship ship) 
        {
            ships.Add(ship);
        }

        public void SendToDespetcher(string message, Ship ship, string addressee)
        {            
            var iteam = ships.Where(ship => ship.Name.Equals(addressee)).FirstOrDefault();

            iteam.ResiveMessage();                      
        }
    }
}
