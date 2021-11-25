using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class PostToDoveAdapter:IMessage
    {
        IOldFashionMessage dove;
        public PostToDoveAdapter(IOldFashionMessage bird)
        {
            dove = bird;
        }

        public void Send(string text)
        {
            dove.KickTheBird(text);
        }
    }
}
