using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Task.Interfaces;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("TestTask")]
namespace Task
{
    public static class Logger
    {
        public static List<string> Messages { get; } = new List<string>();
        public static void WriteLine(string log)
        {
            Messages.Add(log);
            //using (StreamWriter writer = File.AppendText($@"{Directory.GetCurrentDirectory()}\Logger.txt"))
            //{
            //    writer.WriteLine($"{DateTime.UtcNow} - {log}");
            //}
        }
    }
}