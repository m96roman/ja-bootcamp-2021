using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    abstract class Computer
    {
        public string Type { get; protected set; }

        public Computer(string type)
        {
            this.Type = type;
        }
    }
}
