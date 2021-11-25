using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Dove : IOldFashionMessage
    {
        public void KickThebird(string text)
        {
            Console.WriteLine($"Message {text}");
            Console.WriteLine("Message was swnd by bird");
        }
    }
}
