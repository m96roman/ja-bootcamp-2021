using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADovhanych_Task4
{
    class InvalidBatteryLevelException : Exception
    {
        public InvalidBatteryLevelException() { }
        public InvalidBatteryLevelException(string message) : base(message) { }
    }
}
