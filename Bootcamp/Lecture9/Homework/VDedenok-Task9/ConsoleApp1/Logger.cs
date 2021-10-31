using System;
using System.IO;

namespace VDedenok_Task9
{
    class Logger
    {
        public void WriteLine(string logedMessage)
        {
            File.AppendAllText("PhoneExeptions.txt", $"{DateTime.UtcNow} {logedMessage}");
        }
    }
}
