using ConsoleApp4.Interfaces;

namespace ConsoleApp4
{
    public class Driver : IAccount
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Birthday { get; set; }
        public long NumberDrivingLicense { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitDriver(this);
        }
    }
}
