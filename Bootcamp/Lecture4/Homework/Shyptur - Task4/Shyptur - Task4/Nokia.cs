﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shyptur___Task4
{
    class Nokia : Phone
    {
          public Nokia(int baterylevel)
        {
            this.BateryLevel = baterylevel;
        }
        public   void PrayForBattery()
        {
            BateryLevel += 8;
            Console.WriteLine("praying for the battery");
        }
    }
}
