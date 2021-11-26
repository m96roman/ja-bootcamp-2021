using System;

namespace Decorator
{
    public class ComputerDecorator : IComputer
    {
        private readonly IComputer actualComputer;

        public ComputerDecorator(IComputer computer, bool hasWifi = false, bool hasLight = false)
        {
            actualComputer = computer;
            HasWifi = hasWifi;
            HasLight = hasLight;
        }

        public bool HasWifi { get; set; }

        public bool HasLight { get; set; }

        public ComputerType ComputerType { get => actualComputer.ComputerType; set => actualComputer.ComputerType = value; }

        public void PrintInfo()
        {
            actualComputer.PrintInfo();

            var message = this.HasWifi ? "With wifi" : "Without wifi";
            var message2 = this.HasLight ? "With light" : "Without light";

            Console.WriteLine(message + " " + message2);
        }
    }
}
