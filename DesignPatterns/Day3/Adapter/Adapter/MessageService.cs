using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class MessageService 
    {
        public void SendMessage(IMessage message)
        {
            message.Send();
        }
    }
}
