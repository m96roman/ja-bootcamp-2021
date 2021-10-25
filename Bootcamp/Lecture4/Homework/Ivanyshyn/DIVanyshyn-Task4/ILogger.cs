using System.Runtime.CompilerServices;

namespace DIVanyshyn_Task4
{
    public interface ILogger
    {
        void WriteLine(string message, MessageType messageType);
    }
}
