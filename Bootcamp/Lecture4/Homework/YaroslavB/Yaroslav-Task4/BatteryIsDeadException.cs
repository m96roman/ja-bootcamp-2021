using System;

namespace Yaroslav_Task4
{
    public class BatteryIsDeadException : Exception
    {
        public MobilePhone PhoneInstance { get; }

        public BatteryIsDeadException(MobilePhone phone)
        {
            PhoneInstance = phone;
        }
    }
}
