using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    abstract class Operator
    {
        public abstract void SendMessage(string message, Captain captain);
    }
}
