using System;

namespace Yaroslav_Task4
{
    public class Nokia : IPhone
    {
        public string PhoneType => "Nokia";

        #region Constants

        private const int _minBatteryLevel = 0;

        private const int _maxBatteryLevel = 100;

        private const int _minAllowedBatteryLevel = 5;

        private const int _batteryDischargeStep = 5;

        private const int _batteryABitChargeStep = 1;

        private const int _bateryPrayChargeStep = 8;

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


        public Nokia(int batteryLevel)
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

        public void PrayForBattery()
        {
            _batteryLevel += _bateryPrayChargeStep;

            Console.WriteLine("Praying for the battery");
        }
    }

}
