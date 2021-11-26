using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Email : IMessage
    {
        public void Send()
        {
            Console.WriteLine($"Message was sent on mail");
        }
    }
}
