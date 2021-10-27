using System;
using System.IO;

namespace SquareEquation
{
    class LogSaver : ILogger
    {
        public void Log(string message, string path = null)
        {
            SaveToFile(message, path);
        }

        public void Log(string message, MessageType messageType, string path = null)
        {
            SaveToFile($"{messageType}: {message}", path);
        }


        private void SaveToFile(string content, string path)
        {
            try
            {
                File.WriteAllText(path, content);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

        }
    }

}