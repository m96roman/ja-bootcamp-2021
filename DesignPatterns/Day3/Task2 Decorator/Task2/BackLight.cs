using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class BackLight : ComputerDecorator
    {
        public BackLight(AbstractComputer computer) : base(computer.Name + " BackLight", computer)
        {

        }
    }
}
