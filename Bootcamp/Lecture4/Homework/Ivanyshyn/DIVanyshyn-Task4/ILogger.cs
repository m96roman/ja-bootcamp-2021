using System.Runtime.CompilerServices;

namespace DIVanyshyn_Task4
{
    internal interface ILogger
    {
        void WriteLine(string message, MessageType messageType);
    }
}
