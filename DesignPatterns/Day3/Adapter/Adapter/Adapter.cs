using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Adapter : IMessage 
    {
        private IOldFashionMessage _OldFashionMessage { get; set; }

        public Adapter(IOldFashionMessage oldFashionMessage) 
        {
            this._OldFashionMessage = oldFashionMessage;
        }

        public void Send(string text)
        {
            _OldFashionMessage.KickThebird(text);
        }
    }
}
