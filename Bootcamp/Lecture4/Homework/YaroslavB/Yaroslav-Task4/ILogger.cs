namespace Yaroslav_Task4
{
    public interface ILogger
    {
        void Log(string message);
        void Log(string message, MessageType messageType);
    }
}