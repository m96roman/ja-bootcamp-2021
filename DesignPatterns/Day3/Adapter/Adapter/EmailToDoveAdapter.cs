using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class EmailToDoveAdapter : IMessage
    {
        private Dove _dove;

        public EmailToDoveAdapter(Dove dove)
        {
            _dove = dove;
        }

        public void Send()
        {
            _dove.KickTheBird("message");
        }
    }
}
