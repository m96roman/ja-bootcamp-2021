using System;

namespace ConsoleApp4
{
    public abstract class Component
    {
        protected string Name { get; set; }

        public Component(string name)
        {
            Name = name;
        }

        public virtual void Add(Component component) { }

        public virtual void Remove(Component component) { }

        public virtual void GetInfo()
        {
            Console.WriteLine($"  File: {Name}");
        }
    }
}
