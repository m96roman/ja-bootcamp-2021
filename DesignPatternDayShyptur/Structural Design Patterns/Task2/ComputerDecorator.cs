using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public abstract class ComputerDecorator:Computer
    {

        protected Computer Computer;
        public ComputerDecorator(string name, Computer computer) : base(name)
        {
            this.Computer = computer;
        }     
    }
}
