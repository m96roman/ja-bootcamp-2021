using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Car : ITransport
    {
        public void Delivery()
        {
            Console.WriteLine("Delivering on car");
        }
    }
}
