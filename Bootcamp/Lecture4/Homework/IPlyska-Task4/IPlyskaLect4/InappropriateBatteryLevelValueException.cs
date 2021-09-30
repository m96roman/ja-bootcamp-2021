using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IPlyskaLect4
{
    public class InappropriateBatteryLevelValueException : Exception
    {
        public InappropriateBatteryLevelValueException()
        {
        }

        public InappropriateBatteryLevelValueException(string message) : base(message)
        {
        }

        public InappropriateBatteryLevelValueException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InappropriateBatteryLevelValueException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
