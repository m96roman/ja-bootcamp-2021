namespace SquareEquation
{
    public interface ILogger
    {
        void Log(string message, string path = "");
        void Log(string message, MessageType messageType, string path = "");
    }

}