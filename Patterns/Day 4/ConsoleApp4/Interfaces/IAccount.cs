namespace ConsoleApp4.Interfaces
{
    public interface IAccount
    {
        void Accept(IVisitor visitor);
    }
}
