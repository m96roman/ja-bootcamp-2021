﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface IProduct
    {
        public string Front { get; set; }
        public string Back { get; set; }
        public string Collar { get; set; }
        public string Hood { get; set; }
    }
}
