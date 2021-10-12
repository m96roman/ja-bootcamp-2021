using System;

namespace YaroslavB_Task9
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
