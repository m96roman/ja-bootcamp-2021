namespace Mediator
{
    public interface IDispatcher
    {
        void Notify(object sender, string receiverName, string message);
    }
}