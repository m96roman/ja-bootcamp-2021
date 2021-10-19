using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("TestTask")]
namespace Task.Interfaces
{
    public interface ILogger
    {
        void LogMessage(string message);
    }
}
