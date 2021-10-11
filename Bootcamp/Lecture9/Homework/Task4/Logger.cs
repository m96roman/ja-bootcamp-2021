using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Task4
{
    public static class Logger
    {
        public static void WriteLine(string log)
        {
            using (StreamWriter writer = File.AppendText($@"C:\Projects\Lecture 9 .Net\Task4\Logger.txt"))
            {
                writer.WriteLine($"{DateTime.UtcNow} - {log}");
            }
        }
    }
}