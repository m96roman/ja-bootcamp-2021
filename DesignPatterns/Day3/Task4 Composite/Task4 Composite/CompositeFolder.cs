using System;
using System.Collections.Generic;
using System.Text;

namespace Task4_Composite
{
    class CompositeFolder: Component
    {
        List<Component> children = new List<Component>();
        public bool CanHoldChildren { get { return true; } }

        public CompositeFolder(string name):base(name)
        { }

        public override void Add(Component component)
        {
            children.Add(component);
        }

        public override void Display()
        {
            Console.WriteLine(Name);

            foreach (var component in children)
            {
                component.Display();
            }
        }

        public override void Remove(Component component)
        {
            children.Remove(component);
        }
    }
}
