namespace ConsoleApp2
{
    public class ComputerDecorator : Computer
    {
        public Computer _computer;

        public ComputerDecorator(Computer computer) : base(computer)
        {
            this._computer = computer;
        }
    }
}
