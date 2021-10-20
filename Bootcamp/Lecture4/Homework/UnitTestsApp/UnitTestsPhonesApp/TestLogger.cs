using ADovhanych_Task4;
using System;
using System.Collections.Generic;

namespace UnitTestsPhonesApp
{
    class TestLogger : ILogger
    {
        public List<string> Messages { get; } = new List<string>();

        public void LogInfo(string message)
        {
            Messages.Add(message);
        }
    }
}
