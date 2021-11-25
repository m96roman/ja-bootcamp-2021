using ConsoleApp2.Enums;

namespace ConsoleApp2
{
    public class WorkComputer : Computer
    {
        public WorkComputer(string name, ComputerTypes type) : base(name, type) { }

        public override string ToString()
        {
            string computerInfo = $"Name: {Name}, Type: {Type},";

            computerInfo += Light == true ? " Light: Yes," : " Light: No,";
            computerInfo += WiFi == true ? " WiFi: Yes" : " WiFi: No";

            return computerInfo;
        }
    }
}
