using System.Collections.Generic;
using Task.Interfaces;

namespace TestTask
{
    public class FakeLogger : ILogger
    {
        public List<string> Messages { get; } = new List<string>();

        public void LogMessage(string message)
        {
            Messages.Add(message);
        }
    }
}
