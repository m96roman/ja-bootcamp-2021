namespace ConsoleApp4.Interfaces
{
    public interface IVisitor
    {
        void VisitDriver(Driver driver);
        void VisitCar(Car car);
    }
}
