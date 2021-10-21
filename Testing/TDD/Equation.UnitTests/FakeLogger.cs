using System.Collections.Generic;
using Equation.Interfaces;

namespace Equation.UnitTests
{
    public class FakeLogger : ILogger
    {
        public List<string> Messages { get; } = new List<string>();

        public void LogMessage(string message)
        {
            Messages.Add(message);
        }

        public static FakeLogger InitLogger()
        {
            var logger = new FakeLogger();
            Equation.Program._Logger = logger;
            return logger;
        }
    }
}
