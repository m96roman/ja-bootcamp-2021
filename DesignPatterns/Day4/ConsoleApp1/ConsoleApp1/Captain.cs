using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    abstract class Captain
    {
        protected Operator _operator;

        public Captain(Operator opr)
        {
            this._operator = opr;
        }

        public virtual void SendMessage(string message)
        {
            _operator.SendMessage(message, this);
        }

        public abstract void SpeakToCaptain(string message);
    }
}
