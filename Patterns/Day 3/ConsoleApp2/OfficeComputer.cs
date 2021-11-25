using ConsoleApp2.Enums;

namespace ConsoleApp2
{
    public class OfficeComputer : Computer
    {
        public OfficeComputer(string name, ComputerTypes type) : base(name, type) { }

        public override string ToString()
        {
            string computerInfo = $"Name: {Name}, Type: {Type},";

            computerInfo += Light == true ? " Light: Yes," : " Light: No,";
            computerInfo += WiFi == true ? " WiFi: Yes" : " WiFi: No";

            return computerInfo;
        }
    }
}
