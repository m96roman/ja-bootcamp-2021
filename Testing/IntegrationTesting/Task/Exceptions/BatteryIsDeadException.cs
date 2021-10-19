using System;
using System.Runtime.CompilerServices;
using Task.Interfaces;

[assembly: InternalsVisibleTo("TestTask")]
namespace Task.Exceptions
{
    [Serializable]
    internal class BatteryIsDeadException : Exception
    {
        public IPhone Phone { get; set; }
        public BatteryIsDeadException() { }
        public BatteryIsDeadException(string message) : base(message) { }
    }
}
