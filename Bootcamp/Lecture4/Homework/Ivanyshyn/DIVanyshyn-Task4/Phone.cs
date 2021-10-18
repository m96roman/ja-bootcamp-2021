using System;

namespace DIVanyshyn_Task4
{
    internal abstract class Phone : IChargable
    {
        private readonly string phoneName;

        internal ILogger logger { get; }

        protected int batteryLevel;

        protected Phone(int batteryLevel, string phoneName, ILogger logger)
        {
            if (batteryLevel < 0 || batteryLevel > 100)
            {
                throw new ArgumentException($"{nameof(batteryLevel)} parameter must be in range from 0 to 100", nameof(batteryLevel));
            }

            this.batteryLevel = batteryLevel;
            this.phoneName = phoneName;
            this.logger = logger;
        }

        /// <summary>
        /// - when battery level is >= 5%, decrease charge by 5%, print "calling an ambulance from {phoneName}, remaining charge: x%";
        ///- when battery level is bellow 5%, set battery level to 0 and throw an BatteryIsDeadException passing Phone instance as an info
        /// </summary>
        /// <exception cref="BatteryIsDeadException">Throws when battery level lower than 5</exception>
        public void CallForAmbulance()
        {
            if (batteryLevel < 5)
            {
                batteryLevel = 0;
                throw new BatteryIsDeadException(this);
            }

            batteryLevel -= 5;
            logger.WriteLine($"Calling an ambulance for phone {phoneName} remaining charge {batteryLevel}%", MessageType.Message);
        }

        /// <summary>
        /// increase battery level up to 100%, print "Charging {phoneName} to 100%"
        /// </summary>
        public void Charge()
        {
            batteryLevel = 100;
            logger.WriteLine($"Charging {phoneName} to 100%", MessageType.Message);
        }

        /// <summary>
        /// should increase battery level by 1%, print "Charging {phoneName} by 1%"
        /// </summary>
        public void ChargeABit()
        {
            batteryLevel += 1;
            logger.WriteLine($"Charging {phoneName} by 1%", MessageType.Message);
        }

        /// <summary>
        /// prints $"Phone {phoneName} has a battery level {batteryLevel}"
        /// </summary>
        public void Status()
        {
            logger.WriteLine($"Phone {phoneName} has a battery level {batteryLevel}", MessageType.Message);
        }
    }
}