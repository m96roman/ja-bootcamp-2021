namespace Visitor
{
    internal interface IModel
    {
        void AcceptVisitor(ISerializerVisitor serializerVisitor);
    }
}