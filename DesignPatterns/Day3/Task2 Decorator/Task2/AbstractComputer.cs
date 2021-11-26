using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal abstract class AbstractComputer
    {
        public string Name { get; set; }

        public AbstractComputer(string name)
        {
            Name = name;
        }
    }
}
