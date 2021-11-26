using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
   public class LvivShip:BaseShip
    {
        public void SendFromUzh()
        {
            Console.WriteLine("Uzh send to Lviv");        
        }
        public void SendFromKyiv()
        {
            Console.WriteLine("Kyiv send to Lviv");
        }
    }
}
