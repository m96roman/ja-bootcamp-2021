﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class RoadLogistics : ILogistics
    {
        public ITransport CreateTransport()
        {
            return new Truck();
        }
    }
}
