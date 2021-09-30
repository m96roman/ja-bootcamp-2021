using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADovhanych_Task4
{
    public class BatteryIsDeadException : Exception
    {
        public BatteryIsDeadException() { }

        public BatteryIsDeadException(string message) : base(message) { }

        public BatteryIsDeadException(string message, Exception inner) : base(message, inner) { }

        protected BatteryIsDeadException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
