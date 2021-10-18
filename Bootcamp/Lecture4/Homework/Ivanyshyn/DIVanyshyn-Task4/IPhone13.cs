namespace DIVanyshyn_Task4
{
    internal class IPhone13 : Phone
    {
        /// <summary>
        /// Creates a new intance of phone.
        /// throws <see cref="ArgumentException"/> when <paramref name="batteryLevel"/> is not in range from 0 to 100
        /// </summary>
        /// <param name="batteryLevel"></param>
        /// <exception cref="ArgumentException">When battery level is not in range from 0 to 100</exception>
        public IPhone13(int batteryLevel, string phoneName, ILogger logger) : base(batteryLevel, phoneName, logger)
        {
        }
    }
}