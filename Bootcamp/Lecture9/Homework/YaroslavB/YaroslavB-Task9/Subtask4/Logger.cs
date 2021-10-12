using System;
using System.IO;

namespace YaroslavB_Task9
{
    class Logger
    {
        private static string _logPath = "emergencyLog.txt";

        public static void WriteLine(string message)
        {
            string textToLog = $"{DateTime.UtcNow} - {message}{Environment.NewLine}";
            File.AppendAllText(_logPath, textToLog);
        }
    }
}
