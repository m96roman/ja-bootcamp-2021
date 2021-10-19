using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shyptur___Task4
{
    class MessageLogger: IMessageLogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
