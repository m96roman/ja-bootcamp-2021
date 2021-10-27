using System;

namespace YaroslavB_Task9
{
    public class IPhone13 : IPhone
    {
        public string PhoneType => "iPhone 13";

        #region Constants

        private const int _minBatteryLevel = 0;
        private const int _maxBatteryLevel = 100;
        private const int _minAllowedBatteryLevel = 5;
        private const int _batteryDischargeStep = 5;
        private const int _batteryABitChargeStep = 1;

        #endregion

        private int _batteryLevel;
        public int BatteryLevel
        {
            get { return _batteryLevel; }
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Value is out of range: 0 - 100");
                }
                _batteryLevel = value;
            }
        }

        public IPhone13(int batteryLevel)
        {
            BatteryLevel = batteryLevel;
        }

        public void CallAmbulance()
        {
            Console.WriteLine($"Battry level - {_batteryLevel}%");

            if (_batteryLevel < _minAllowedBatteryLevel)
            {
                _batteryLevel = _minBatteryLevel;
                throw new BatteryIsDeadException(this);
            }

            _batteryLevel -= _batteryDischargeStep;
            Console.WriteLine($"Calling an ambulance from {PhoneType}, remaining charge: {_batteryLevel}%");
        }

        public void Charge()
        {
            _batteryLevel = _maxBatteryLevel;
            Console.WriteLine($"Charging {PhoneType} to {_batteryLevel}%");
        }

        public void ChargeABit()
        {
            _batteryLevel += _batteryABitChargeStep;
            Console.WriteLine($"Charging {PhoneType} by {_batteryABitChargeStep}%");
        }
    }
}
