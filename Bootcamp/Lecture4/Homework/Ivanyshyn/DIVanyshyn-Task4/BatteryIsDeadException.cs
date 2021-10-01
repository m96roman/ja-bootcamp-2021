using System;
using System.Runtime.Serialization;

namespace DIVanyshyn_Task4
{
    [Serializable]
    internal class BatteryIsDeadException : Exception
    {
        public Phone Phone { get; private set; }

        public BatteryIsDeadException()
        {
        }

        public BatteryIsDeadException(Phone phone) : this($"Phone {phone.GetType()} need help!")
        {
            this.Phone = phone;
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