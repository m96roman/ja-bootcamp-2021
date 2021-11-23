using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Plane : ITransport
    {
        public void Delivery()
        {
            Console.WriteLine("Delivering on plane");
        }
    }
}
