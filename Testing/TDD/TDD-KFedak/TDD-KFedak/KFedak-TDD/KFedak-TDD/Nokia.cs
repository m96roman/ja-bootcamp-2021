using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedak_TDD
{
    public class Nokia : Phone, ITelephone
    {
        internal ILogger logger;

        public Nokia(int battery, string name, ILogger logger) : base(battery, name, logger)
        {
            this.logger = logger;
        }

        public void PrayForBattery()
        {
            this.BatteryLevel += 8;
            logger.WriteLine(new Exception("Praying for the battery"));
            //Console.WriteLine("Praying for the battery");
        }
    }
}
