using System;

namespace Yaroslav_Task4
{
    public abstract class MobilePhone
    {
        protected const int _minBatteryLevel = 0;
        protected const int _maxBatteryLevel = 100;
        protected const int _minAllowedBatteryLevel = 5;
        protected const int _batteryDischargeStep = 5;
        protected const int _batteryABitChargeStep = 1;

        protected int _batteryLevel;
        protected ILogger _logger;
        public int BatteryLevel
        {
            get { return _batteryLevel; }
            private set
            {
                if (value < _minBatteryLevel || value > _maxBatteryLevel)
                {
                    throw new ArgumentOutOfRangeException("Value is out of range: 0 - 100");
                }
                _batteryLevel = value;
            }
        }

        protected MobilePhone(int batteryLevel, ILogger logger)
        {
            BatteryLevel = batteryLevel;
            _logger = logger;
        }

        public abstract string PhoneType { get; }

        public virtual void ChargeABit()
        {
            _batteryLevel += _batteryABitChargeStep;
            _logger.Log($"Charging {PhoneType} by {_batteryABitChargeStep}%");
        }

        public virtual void CallAmbulance()
        {
            //Console.WriteLine($"Battry level - {_batteryLevel}%");

            if (_batteryLevel < _minAllowedBatteryLevel)
            {
                _batteryLevel = _minBatteryLevel;
                throw new BatteryIsDeadException(this);
            }

            _batteryLevel -= _batteryDischargeStep;
            _logger.Log($"Calling an ambulance from {PhoneType}, remaining charge: {_batteryLevel}%", MessageType.Successful);
        }

        public virtual void Charge()
        {
            _batteryLevel = _maxBatteryLevel;
            _logger.Log($"Charging {PhoneType} to {_batteryLevel}%", MessageType.Warning);
        }
    }
}
