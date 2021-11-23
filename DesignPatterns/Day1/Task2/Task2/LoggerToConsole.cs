using System;

namespace Task2
{
    public class LoggerToConsole : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
