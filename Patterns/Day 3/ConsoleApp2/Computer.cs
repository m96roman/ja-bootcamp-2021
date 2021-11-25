using ConsoleApp2.Enums;

namespace ConsoleApp2
{
    public abstract class Computer
    {
        public string Name { get; set; }
        public ComputerTypes Type { get; set; }
        public bool Light  { get; set; } = false;
        public bool WiFi  { get; set; } = false;

        public Computer(string name, ComputerTypes type)
        {
            Name = name;
            Type = type;
        }

        public Computer(Computer computer)
        {
            this.Name = computer.Name;
            this.Type = computer.Type;
            this.Light = computer.Light;
            this.WiFi = computer.WiFi;
        }
    }
}
