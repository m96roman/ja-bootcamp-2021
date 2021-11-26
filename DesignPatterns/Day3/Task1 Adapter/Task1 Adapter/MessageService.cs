using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_Adapter
{
    public class MessageService : IMessage
    {
        HomingPigeon pigeon;

        public MessageService(HomingPigeon h)
        {
            pigeon = h;
        }

        public void Send(string text)
        {
            pigeon.SendByPigeon(text);
        }
    }
}
