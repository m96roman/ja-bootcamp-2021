using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
   public class UzhShip:BaseShip
    {
        public void SendFromKyiv()
        {
            Console.WriteLine("Kyiv send to  Uzh");
        }
        public void SendFromLviv()
        {
            Console.WriteLine("Lviv send to  Uzh");
        }
    }
}
