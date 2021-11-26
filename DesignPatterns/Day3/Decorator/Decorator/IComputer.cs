namespace Decorator
{
    public interface IComputer
    {
        ComputerType ComputerType { get; set; }

        void PrintInfo();
    }
}