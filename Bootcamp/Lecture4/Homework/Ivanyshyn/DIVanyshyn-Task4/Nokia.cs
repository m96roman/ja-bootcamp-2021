namespace DIVanyshyn_Task4
{
    internal class Nokia : Phone
    {
        /// <summary>
        /// Creates a new intance of phone.
        /// throws <see cref="ArgumentException"/> when <paramref name="batteryLevel"/> is not in range from 0 to 100
        /// </summary>
        /// <param name="batteryLevel"></param>
        /// <exception cref="ArgumentException">When battery level is not in range from 0 to 100</exception>
        public Nokia(int batteryLevel, string phoneName, ILogger logger) : base(batteryLevel, phoneName, logger)
        {
        }

        /// <summary>
        /// Adds to batteryLevel 8% and prints message "praying for the battery"
        /// </summary>
        public void PrayForBattery()
        {
            batteryLevel += 8;
            logger.WriteLine("Praying for battery (Thank god for another day with Nokia)", MessageType.Message);
        }
    }
}