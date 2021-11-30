using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class BacklightDecorator : ComputerDecorator
    {
        public BacklightDecorator(Computer computer)
            : base (computer, $"Computer ot type {computer._type} with backlight." )
        {}

        public override int Price()
        {
            return computer.Price() + 5;
        }
    }
}
