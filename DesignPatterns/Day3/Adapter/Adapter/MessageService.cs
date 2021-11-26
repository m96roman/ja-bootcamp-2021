using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class MessageService
    {
        public void SendMessage(IMessage message, string text) 
        {
            message.Send(text);
        }
    }
}
