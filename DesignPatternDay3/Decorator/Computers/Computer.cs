using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Computer
    {
        public string _type;

        public Computer(string purpose)
        {
            this._type = purpose;
        }

        public abstract int Price();
    }
}
