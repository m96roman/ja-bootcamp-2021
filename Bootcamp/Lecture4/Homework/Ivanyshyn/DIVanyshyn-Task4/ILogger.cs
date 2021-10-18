using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("DIvanyshyn-UnitTests-Day1")]
namespace DIVanyshyn_Task4
{
    internal interface ILogger
    {
        void WriteLine(string message, MessageType messageType);
    }
}
