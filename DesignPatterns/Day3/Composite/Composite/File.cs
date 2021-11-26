namespace Composite
{
    public class File : CompositeUnit
    {
        public File(string name) : base(name)
        {
        }

        public override bool IsDirectory => false;

        public override void AppendChildren(IComposite composite)
        {
        }

        public override IComposite[] GetChildrens()
        {
            return null;
        }

        public override IComposite GetChildWithName(string name)
        {
            return null;
        }

        public override void RemoveChildren(IComposite composite)
        {
        }
    }
}
