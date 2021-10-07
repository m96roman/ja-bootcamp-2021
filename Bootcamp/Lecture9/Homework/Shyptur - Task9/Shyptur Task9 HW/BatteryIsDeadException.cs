using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Shyptur_Task9_HW
{
    class BatteryIsDeadException : Exception
    {
        public Phone PhoneInfo { get; set; }

        public BatteryIsDeadException()
        {

        }

        public BatteryIsDeadException(string message) : base(message)
        {
        }

        public BatteryIsDeadException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BatteryIsDeadException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
