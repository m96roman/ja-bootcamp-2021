namespace ConsoleApp1
{
    public class PlaneCarry : LogicalCompany
    {
        public PlaneCarry(Stone stone) : base(stone) { }

        public override Stone Carry()
        {
            return _stone;
        }
    }
}
