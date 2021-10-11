using System;
using System.Collections.Generic;
using System.Text;
using Task4.Interfaces;

namespace Task4.Exceptions
{
    [Serializable]
    class BatteryIsDeadException : Exception
    {
        public IPhone Phone { get; set; }
        public BatteryIsDeadException() { }
        public BatteryIsDeadException(string message) : base(message) { }
    }
}
