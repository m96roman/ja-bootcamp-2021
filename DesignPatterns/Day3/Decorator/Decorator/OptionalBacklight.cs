using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class OptionalBacklight : ComputerDecorator
    {
        public OptionalBacklight(Computer computer) : base(computer.Type + " with backlight", computer) { }
    }
}
