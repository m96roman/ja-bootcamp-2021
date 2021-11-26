using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Expert
    {
        public string Name { get; set; }
        public IDecorator Decorator { get; set; }

        public Expert(string name, IDecorator decorator)
        {
            Name = name;
            Decorator = decorator;
        }

        public void Decorate()
        {
            Decorator.Decorate();
        }
    }
}
