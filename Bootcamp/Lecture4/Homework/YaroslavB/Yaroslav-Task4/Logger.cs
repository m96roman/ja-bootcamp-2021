using System;

namespace Yaroslav_Task4
{
    class Logger : ILogger
    {
        public void Log(string message)
        {
            Log(message, MessageType.Default);
        }

        public void Log(string message, MessageType messageType)
        {
            var defaultColor = Console.ForegroundColor;

            ConsoleColor color = messageType switch
            {
                MessageType.Successful => ConsoleColor.DarkGreen,
                MessageType.Warning => ConsoleColor.Yellow,
                MessageType.Error => ConsoleColor.Red,
                _ => defaultColor
            };

            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
