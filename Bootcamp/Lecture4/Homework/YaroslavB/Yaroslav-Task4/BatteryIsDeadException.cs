using System;

namespace Yaroslav_Task4
{
    public class BatteryIsDeadException : Exception
    {
        public IPhone PhoneInstance { get; }

        public BatteryIsDeadException(IPhone phone)
        {
            PhoneInstance = phone;
        }
    }
}
