namespace Observer
{
    public interface IClient
    {
        void NotifyFor(MessageType waterOff, string message);
    }
}