using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRoshko_Task4
{   
    internal class Logger
    {
        public static List<string> logList = new List<string>();
        internal string Message { get; set; }

        public Logger(string message) 
        {
            Message = message;
            logList.Add(Message);
            PrintMessage(Message);
        }

        public void PrintMessage(string log) 
        {
            Console.WriteLine(log);
        }
    }
}
