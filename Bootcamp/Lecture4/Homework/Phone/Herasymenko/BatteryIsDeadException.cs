using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herasymenko
{
    public class BatteryIsDeadException : Exception
    {
        public BatteryIsDeadException(string message) : base($"Battery is dead you can't call from {message}") { }
    }
}
