namespace DIvanyshyn_9.HereWeGoAgain
{
    internal class Nokia : Phone
    {
        /// <summary>
        /// Creates a new intance of phone.
        /// throws <see cref="ArgumentException"/> when <paramref name="batteryLevel"/> is not in range from 0 to 100
        /// </summary>
        /// <param name="batteryLevel"></param>
        /// <exception cref="ArgumentException">When battery level is not in range from 0 to 100</exception>
        public Nokia(int batteryLevel, string phoneName) : base(batteryLevel, phoneName)
        {
        }

        public void PrayForBattery()
        {
            batteryLevel += 8;
            System.Console.WriteLine("Praying for battery (Thank god for another day with Nokia)");
        }
    }
}