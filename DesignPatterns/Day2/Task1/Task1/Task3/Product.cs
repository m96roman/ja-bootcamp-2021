﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Product
    {
        private List<string> _parts = new List<string>();

        public void Add(string part)
        {
            this._parts.Add(part);
        }    
    }
}
