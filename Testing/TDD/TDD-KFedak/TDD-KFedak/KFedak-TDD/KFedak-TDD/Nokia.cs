using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedak_TDD
{
    public class Nokia : Phone, ITelephone
    {
        public ILogger Logger;

        public Nokia(int battery, string name, ILogger logger) : base(battery, name, logger)
        {
            this.Logger = logger;
        }

        public void PrayForBattery()
        {
            this.BatteryLevel += 8;
            Logger.WriteLine(new Exception("Praying for the battery"));
        }
    }
}
