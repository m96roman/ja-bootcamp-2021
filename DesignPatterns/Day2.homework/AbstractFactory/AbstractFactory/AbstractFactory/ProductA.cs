using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class ProductA : IProduct
    {
        public string Back { get; set; }
        public string Hood { get; set; }
        public string Collar { get; set; }
        public string Front { get; set; }
    }
}
