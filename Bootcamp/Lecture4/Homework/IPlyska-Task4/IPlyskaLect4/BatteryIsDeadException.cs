using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IPlyskaLect4
{
    public class BatteryIsDeadException : Exception
    {
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
