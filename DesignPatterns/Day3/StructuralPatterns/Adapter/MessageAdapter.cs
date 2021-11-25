using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class MessageAdapter : IMessage
    {
        private readonly Dove dove;

        public MessageAdapter(Dove dove)
        {
            this.dove = dove;
        }

        public void Send(string text)
        {
            dove.KickTheBird(text);
        }
    }
}
