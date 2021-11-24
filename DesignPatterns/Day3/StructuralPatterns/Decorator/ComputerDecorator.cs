using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal abstract class ComputerDecorator : Computer
    {
        protected Computer Computer;
        protected ComputerDecorator(string name, Computer computer) : base(name)
        {
            this.Computer = computer;
        }
    }
}
