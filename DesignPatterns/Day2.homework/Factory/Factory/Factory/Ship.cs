using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Ship : ITransport
    {
        public void Delivery()
        {
            Console.WriteLine("Delivering on ship");
        }
    }
}
