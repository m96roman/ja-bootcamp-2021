using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class KyivShip:BaseShip
    {
        public void SendFromUzh()
        {
            Console.WriteLine("uzh send to Kiev");      
        }
        public void SendFromLviv()
        {
            Console.WriteLine("Lviv send to  Kiev");
        }
    }
}
