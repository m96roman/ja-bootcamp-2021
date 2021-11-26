using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory_v2
{
    class Clothes : IFront, IHood, ICollar, IBack
    {
        public string Back { get; set; }
        public string Collar { get; set; }
        public string Hood { get; set; }
        public string Front { get; set; }
    }
}
