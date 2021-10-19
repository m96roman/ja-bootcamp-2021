using System;
using System.Collections.Generic;
using System.Text;
using Task.Interfaces;

namespace TestTask
{
    class FakeLogger : ILogger
    {
        public List<string> Messages { get; } = new List<string>();

        public void LogMessage(string message)
        {
            Messages.Add(message);
        }
    }
}
