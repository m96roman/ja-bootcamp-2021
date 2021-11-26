namespace Decorator
{
    class Computer : IComputer
    {
        public Computer(ComputerType computerType)
        {
            ComputerType = computerType;
        }

        public ComputerType ComputerType { get; set; }

        public void PrintInfo()
        {
            System.Console.WriteLine($"I am computer with {ComputerType} type");
        }
    }
}
