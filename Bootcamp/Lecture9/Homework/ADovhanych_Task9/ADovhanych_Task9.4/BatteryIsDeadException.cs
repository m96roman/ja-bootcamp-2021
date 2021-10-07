using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADovhanych_Task9._4
{
    public class BatteryIsDeadException : Exception
    {
        public Phone PhoneInfo { get; set; }
        public BatteryIsDeadException() { }

        public BatteryIsDeadException(string message) : base(message) { }
    }
}
