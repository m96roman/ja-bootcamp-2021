using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    public class Directory : Component
    {
        private List<Component> components = new List<Component>();

        public Directory(string name) : base(name) { }

        public override void Add(Component component)
        {
            components.Add(component);
        }

        public override void Remove(Component component)
        {
            components.Remove(component);
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Directory: {Name}");
            Console.WriteLine($" Directories and files in {Name}:");

            for (int i = 0; i < components.Count; i++)
            {
                components[i].GetInfo();
            }
            Console.WriteLine();
        }
    }
}
