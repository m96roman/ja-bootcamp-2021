using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class WithLight : ComputerDecorator
    {
        public WithLight(Computer computer) : base(computer.name + " + Light", computer) { }
        public override void Display()
        {
            Computer.Display();
        }
    }
}
