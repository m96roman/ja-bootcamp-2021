using ConsoleApp4.Interfaces;

namespace ConsoleApp4
{
    public class Car : IAccount
    {
        public string Model { get; set; }
        public string Number { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitCar(this);
        }
    }
}
