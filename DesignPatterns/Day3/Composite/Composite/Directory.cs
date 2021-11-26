using System.Linq;

namespace Composite
{
    public class Directory : CompositeUnit
    {
        public Directory(IComposite[] childrens, string name) : base(name)
        {
            this.childrens = new IComposite[0];

            foreach (var item in childrens)
            {
                AppendChildren(item);
            }
        }

        public override bool IsDirectory => true;

        public override void AppendChildren(IComposite composite)
        {
            composite.Parent = this;
            childrens = childrens.Append(composite).ToArray();
        }

        public override IComposite[] GetChildrens()
        {
            return childrens;
        }

        public override IComposite GetChildWithName(string name)
        {
            return childrens.First(c => c.Name == name);
        }

        public override void RemoveChildren(IComposite composite)
        {
            childrens = childrens.Where(c => !c.Equals(composite)).ToArray();
        }
    }
}
