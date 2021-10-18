using DIVanyshyn_Task4;
using System.Collections.Generic;

namespace DIvanyshyn_UnitTests_Day1
{
    internal class FakeLogger : ILogger
    {
        public List<KeyValuePair<string, MessageType>> FakeLoggerLog { get; set; }
        public FakeLogger()
        {
            FakeLoggerLog = new List<KeyValuePair<string, MessageType>>();
        }

        public void WriteLine(string message, MessageType messageType)
        {
            FakeLoggerLog.Add(new(message, messageType));
        }
    }
}