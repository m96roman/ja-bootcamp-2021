using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Dove : IOldFashionMessage
    {
        public void KickTheBird(string text)
        {
            Console.WriteLine($"повідомлення {text}");
            Console.WriteLine($"message was sent with a Dove");
        }
    }
}
