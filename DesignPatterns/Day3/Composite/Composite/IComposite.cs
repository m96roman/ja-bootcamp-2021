namespace Composite
{
    public interface IComposite
    {
        string Name { get; }

        bool IsDirectory { get; }

        IComposite Parent { get; set; }

        IComposite[] GetChildrens();

        IComposite GetChildWithName(string name);

        void AppendChildren(IComposite composite);

        void RemoveChildren(IComposite composite);
    }
}
