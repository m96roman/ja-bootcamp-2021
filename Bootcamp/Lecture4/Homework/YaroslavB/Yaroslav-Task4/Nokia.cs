using System;

namespace Yaroslav_Task4
{
    public class Nokia : MobilePhone
    {
        private const int _bateryPrayChargeStep = 8;
        public override string PhoneType => "Nokia";
        
        public Nokia(int batteryLevel) : this(batteryLevel, new Logger()){}

        public Nokia(int batteryLevel, ILogger logger) : base(batteryLevel, logger){}

        public void PrayForBattery()
        {
            _batteryLevel += _bateryPrayChargeStep;
            _logger.Log("praying for the battery", MessageType.Warning);
        }
    }
}
