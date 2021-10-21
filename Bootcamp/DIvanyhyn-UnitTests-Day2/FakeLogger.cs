using DIvanyshyn_8.AssembliesExample;
using System.Collections.Generic;

namespace DIvanyhyn_UnitTests_Day2
{
    internal class FakeLogger : ILogger
    {
        public List<string> Messages { get; } = new List<string>();

        public void Log(string message)
        {
            Messages.Add(message);
        }
    }
}