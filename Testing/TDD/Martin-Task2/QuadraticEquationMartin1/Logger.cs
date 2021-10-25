using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquationMartin1
{
    public class Logger
    {
        public string Message { get; private set; }

        public Logger(string message)
        {
            Message = message;
        }

        public void WriteLine()
        {
            Console.WriteLine(Message);
        }
    }
}
