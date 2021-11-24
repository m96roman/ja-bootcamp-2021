using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    abstract class ComputerDecorator : AbstractComputer
    {
        public AbstractComputer computer;
        public ComputerDecorator(string name, AbstractComputer computer) : base(name)
        {
            this.computer = computer;
        }
    }
}
