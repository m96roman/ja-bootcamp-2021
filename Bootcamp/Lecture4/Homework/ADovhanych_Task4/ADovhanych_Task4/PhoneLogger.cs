using System;
using System.Collections.Generic;

namespace ADovhanych_Task4
{
    class PhoneLogger : ILogger
    {
        public List<string> Messages { get; } = new List<string>();

        public void LogInfo(string message)
        {
            Console.WriteLine(message);
            Messages.Add(message);
        }
    }
}
