using System;

namespace Composite
{
    public abstract class CompositeUnit : IComposite
    {
        public IComposite Parent { get; set; }

        protected IComposite[] childrens = null;

        private string name;

        public string Name => name;

        public IComposite GetParent()
        {
            return Parent;
        }

        protected CompositeUnit(string name)
        {
            this.name = name;
        }

        public abstract bool IsDirectory { get; }
        public abstract IComposite[] GetChildrens();
        public abstract IComposite GetChildWithName(string name);
        public abstract void AppendChildren(IComposite composite);
        public abstract void RemoveChildren(IComposite composite);

        public override bool Equals(object obj)
        {
            return obj is CompositeUnit unit &&
                   name == unit.name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name);
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} with name {name}";
        }
    }
}
