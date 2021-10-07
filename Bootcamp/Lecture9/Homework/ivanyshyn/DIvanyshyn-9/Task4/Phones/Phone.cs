using System;

namespace DIvanyshyn_9.HereWeGoAgain
{
    public abstract class Phone : IChargable
    {
        private readonly string phoneName;
        protected int batteryLevel;

        protected Phone(int batteryLevel, string phoneName)
        {
            if (batteryLevel < 0 || batteryLevel > 100)
            {
                throw new ArgumentException($"{nameof(batteryLevel)} parameter must be in range from 0 to 100", nameof(batteryLevel));
            }

            this.batteryLevel = batteryLevel;
            this.phoneName = phoneName;
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
            Console.WriteLine($"Calling an ambulance for phone {phoneName} remaining charge {batteryLevel}%");
        }

        /// <summary>
        /// increase battery level up to 100%, print "Charging {phoneName} to 100%"
        /// </summary>
        public void Charge()
        {
            batteryLevel = 100;
            Console.WriteLine($"Charging {phoneName} to 100%");
        }

        /// <summary>
        /// should increase battery level by 1%, print "Charging {phoneName} by 1%"
        /// </summary>
        public void ChargeABit()
        {
            batteryLevel += 1;
            Console.WriteLine($"Charging {phoneName} by 1%");
        }

        /// <summary>
        /// prints $"Phone {phoneName} has a battery level {batteryLevel}"
        /// </summary>
        public void Status()
        {
            Console.WriteLine($"Phone {phoneName} has a battery level {batteryLevel}");
        }
    }
}