using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class ComputerDecorator : Computer
    {
        protected Computer computer;

        public ComputerDecorator(Computer comp, string type) : base(type)
        {
            this.computer = comp;
        }
    }
}
