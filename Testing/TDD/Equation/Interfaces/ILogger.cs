using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Tests")]
namespace Equation.Interfaces
{
    public interface ILogger
    {
        void LogMessage(string message);
    }
}
