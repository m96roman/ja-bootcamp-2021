using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    public class Product
    {
        List<object> parts = new List<object>();
        public void Add(string part)
        {
            parts.Add(part);
        }
    }
}
