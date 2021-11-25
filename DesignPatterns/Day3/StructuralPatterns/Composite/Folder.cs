using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Folder:Component
    {
        private List<Component> components = new List<Component>();

        private readonly string Name;

        public Folder(string name) : base(name)
        {
            Name = name;
        }

        public override void Add(Component component)
        {
            components.Add(component);
        }

        public override void Remove(Component component)
        {
            components.Remove(component);
        }

        public override void PrintTree()
        {
            Console.WriteLine($"Folder {Name}");
            Console.WriteLine("components:");
            foreach (var component in components)
            {
                component.PrintTree();
            }
        }
    }
}
