using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Plaster : IDecorator
    {
        public void Decorate()
        {
            Console.WriteLine("The wall is plastered");
        }
    }
}
