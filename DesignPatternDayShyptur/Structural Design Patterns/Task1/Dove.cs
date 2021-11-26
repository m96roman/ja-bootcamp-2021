using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Dove : IOldMessage
    {
        public void KickBird(string text)
        {
            Console.WriteLine($"send {text}");
            Console.WriteLine("send with BIRD");
        }
    }
}
