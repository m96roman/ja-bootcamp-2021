using System;
using System.Collections.Generic;
using System.Text;

namespace Task4_Composite
{
    abstract class Component
    {
        protected string Name;
         bool CanHoldChildren { get;}

        public Component(string name)
        {
            Name = name;
        }

        public abstract void Display();
        public abstract void Remove(Component component);
        public abstract void Add(Component component);
    }
}
