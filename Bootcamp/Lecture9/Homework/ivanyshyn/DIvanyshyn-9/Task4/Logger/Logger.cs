using System;
using System.IO;
using System.Text;

namespace DIvanyshyn_9.HereWeGoAgain
{
    sealed class Logger : ILogger
    {
        private static readonly Lazy<Logger> intance = new Lazy<Logger>(() => new Logger());

        public static Logger GetIntance
        {
            get
            {
                return intance.Value;
            }
        }

        public void WriteLine(string message, MessageType messageType = MessageType.Message)
        {
            string fileName = string.Format($"app_run_{DateTime.Now.ToString("yyyy-MM-dd")}.log");
            string logFilePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(new string('-', 20));

            sb.AppendLine($"{DateTime.UtcNow} - {messageType} - {message}");

            using StreamWriter writer = new StreamWriter(logFilePath, true);

            writer.Write(sb.ToString());

            //Just in case...
            writer.Flush();
        }
    }
}
