namespace Visitor
{
    interface ISerializerVisitor
    {
        string SerializeCar(Car car);

        string SerializeDriver(Driver driver);
    }
}
