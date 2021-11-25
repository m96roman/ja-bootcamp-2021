using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Paint : IDecorator
    {
        public void Decorate()
        {
            Console.WriteLine("The wall is painted");
        }
    }
}
