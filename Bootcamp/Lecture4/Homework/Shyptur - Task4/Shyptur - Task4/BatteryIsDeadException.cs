using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Shyptur - UnitTest 1")]
namespace Shyptur___Task4
{
   internal class BatteryIsDeadException : Exception
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

