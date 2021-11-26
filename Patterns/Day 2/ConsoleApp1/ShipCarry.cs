namespace ConsoleApp1
{
    public class ShipCarry : LogicalCompany
    {
        public ShipCarry(Stone stone) : base(stone) { }

        public override Stone Carry()
        {
            return _stone;
        }
    }
}
