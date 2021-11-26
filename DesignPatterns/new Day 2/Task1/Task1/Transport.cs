using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
   abstract class Transport
    {
        public string Name { get; set; }

        public Transport(string name)
        {
            Name = name;
        }

        abstract public Goods Send();
    }
}
