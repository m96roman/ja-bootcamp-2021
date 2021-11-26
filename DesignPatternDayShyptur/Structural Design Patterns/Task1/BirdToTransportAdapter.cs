using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class BirdToTransportAdapter: IMessage
    {
       private IOldMessage _message;

        public BirdToTransportAdapter(IOldMessage message)
        {
            _message = message;
        }
    

        public void Send(string text)
        {
            _message.KickBird(text);
        }
    }
}
