using System;

namespace AdapterPattern
{
    class Dove : IOldFashionMessage
    {
        public void KickTheBird(string message)
        {
            Console.WriteLine($"message {message}");
            Console.WriteLine($"Message sent by dove");
        }
    }
}
