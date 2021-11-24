using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal abstract class Component
    {
        protected readonly string Name;

        public Component(string name)
        {
            this.Name = name;
        }

        public virtual void Add(Component component) { }

        public virtual void Remove(Component component) { }

        public virtual void PrintTree()
        {
            Console.WriteLine(Name);
        }
    }
}
