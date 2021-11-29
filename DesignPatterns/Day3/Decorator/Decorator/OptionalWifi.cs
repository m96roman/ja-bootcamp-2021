using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class OptionalWifi : ComputerDecorator
    {
        public OptionalWifi(Computer computer) : base(computer.Type + " with WiFi", computer) { }
    }
}
