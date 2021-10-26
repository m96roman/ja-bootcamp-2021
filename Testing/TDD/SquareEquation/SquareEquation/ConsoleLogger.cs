using System;

namespace SquareEquation
{
    class ConsoleLogger : ILogger
    {
        public void Log(string message, string path)
        {
            Log(message, MessageType.Default, path);
        }

        public void Log(string message, MessageType messageType, string path)
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