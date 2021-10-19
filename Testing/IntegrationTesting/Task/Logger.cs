using System;
using System.IO;
using Task.Interfaces;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("TestTask")]
namespace Task
{
    internal class Logger : ILogger
    {
        public void LogMessage(string log)
        {
            using (StreamWriter writer = File.AppendText($@"{Directory.GetCurrentDirectory()}\Logger.txt"))
            {
                writer.WriteLine($"{DateTime.UtcNow} - {log}");
            }
        }
    }
}