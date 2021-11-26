namespace ConsoleApp1
{
    public class CarCarry : LogicalCompany
    {
        public CarCarry(Stone stone) : base(stone) { }

        public override Stone Carry()
        {
            return _stone;
        }
    }
}
