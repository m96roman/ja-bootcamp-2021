using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shyptur___Task4
{
    class Nokia : Phone
    {
        public int BateryLevel { get; set; }
        public Nokia(int baterylevel)
        {
            this.BateryLevel = baterylevel;
        }
        public override void PrayForBattery()
        {
            BateryLevel += 8;
            Console.WriteLine("praying for the battery");
        }

       

    }
}
