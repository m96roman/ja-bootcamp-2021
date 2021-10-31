using System;

namespace VDedenok_Task9
{
    class Nokia : Phone
    {
        public void PrayForBattery()
        {
            BatteryLevel += 8;
            Console.WriteLine($"Praying for the battery of {this.GetType().Name}, batteryLevel is now {this.BatteryLevel}!");
        }
    }
}
