namespace ConsoleApp2
{
    public class LightDecorator : ComputerDecorator
    {
        public LightDecorator(Computer computer) : base(computer) 
        {
            _computer.Light = true;
        }

        public override string ToString()
        {
            string computerInfo = $"Name: {_computer.Name}, Type: {_computer.Type},";

            computerInfo += _computer.Light == true ? " Light: Yes," : " Light: No,";
            computerInfo += _computer.WiFi == true ? " WiFi: Yes" : " WiFi: No";

            return computerInfo;
        }
    }
}
