using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("TestTask")]
namespace Task.Interfaces
{
    internal interface ILogger
    {
        void LogMessage(string message);
    }
}
