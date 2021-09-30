using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPlyskaLect4
{
    public class Nokia : Phone
    {
        public void PrayForBattery()
        {
            this.BatteryLevel += 8;
            if (BatteryLevel > 100)
            {
                throw new InappropriateBatteryLevelValueException(BatteryLevel.ToString());
            }

            Console.WriteLine("praying for the battery");
        }
    }
}
