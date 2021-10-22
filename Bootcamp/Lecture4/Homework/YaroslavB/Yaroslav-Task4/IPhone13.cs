using System;

namespace Yaroslav_Task4
{
    public class IPhone13 : MobilePhone
    {
        public override string PhoneType => "iPhone 13";

        public IPhone13(int batteryLevel) : this(batteryLevel, new Logger()){}

        public IPhone13(int batteryLevel, ILogger logger) : base(batteryLevel, logger){}
    }
}
