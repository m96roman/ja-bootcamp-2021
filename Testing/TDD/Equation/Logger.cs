using System;
using System.IO;
using Equation.Interfaces;

namespace Equation
{
    class Logger : ILogger
    {
        public void LogMessage(string message)
        {
            using (StreamWriter writer = File.AppendText($@"{Directory.GetCurrentDirectory()}\Logger.txt"))
            {
                writer.WriteLine($"{DateTime.UtcNow} - {message}");
            }
        }
    }
}
