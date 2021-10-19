using System;
using System.Runtime.CompilerServices;
using Task.Interfaces;
using Task.Enums;

[assembly: InternalsVisibleTo("TestTask")]
namespace Task
{
    internal class Iphone13 : IPhone
    {
        private int _batteryLevel;

        public int BatteryLevel
        {
            get => _batteryLevel;
            set
            {
                if (value >= 0 && value <=100)
                {
                    _batteryLevel = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(paramName: "Catch exception", message: "Battery range must be between 0 and 100");
                }
            }
        }

        public string PhoneName { get; set; }
        public PhoneType Type { get; set; }
        public ILogger _Logger { get; set; }

        public Iphone13(string phoneName, int batteryLevel, PhoneType type, ILogger logger)
        {
            PhoneName = phoneName;
            Type = type;
            _Logger = logger;
            BatteryLevel = batteryLevel;
        }

        public void CallAmbulance()
        {
            if (BatteryLevel >= 5)
            {
                BatteryLevel -= 5;
                _Logger.LogMessage($"calling an ambulance from {PhoneName}, remaining charge: {_batteryLevel}%");
            }
            else
            {
                BatteryLevel = 0;
                _Logger.LogMessage($"{PhoneName} have died battery!");
                throw new Exceptions.BatteryIsDeadException($"{PhoneName} have died battery!")
                {
                    Phone = this
                };
            }
        }
        public void Charge()
        {
            BatteryLevel = 100;
            _Logger.LogMessage($"Charging {PhoneName} to 100%");
        }

        public void ChargeABit()
        {
            BatteryLevel += 1;
            _Logger.LogMessage($"Charging {PhoneName} a bit");
        }
    }
}
