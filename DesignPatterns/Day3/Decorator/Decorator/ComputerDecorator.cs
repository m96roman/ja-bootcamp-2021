using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    abstract class ComputerDecorator : Computer
    {
        protected Computer computer;
        public ComputerDecorator(string type, Computer computer) : base(type)
        {
            this.computer = computer;
        }
    }
}
