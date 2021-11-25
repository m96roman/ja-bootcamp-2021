using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
   internal class Dove:IOldFashionMessage
    {
        public void KickTheBird(string text)
        {
            Console.WriteLine($"message{text}");
            Console.WriteLine($"message send by dove");
        }
    }
}
