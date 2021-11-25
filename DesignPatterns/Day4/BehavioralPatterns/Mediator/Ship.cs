using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal abstract class Ship
    {
        protected Mediator _mediator;

        public string Name { get; set; }

        protected Ship(Mediator mediator)
        {
            _mediator = mediator;
        }

        public virtual void Send(string message, string nameTo)
        {
            _mediator.Send(message, this,  nameTo);
        }

        public abstract void Notify(string message, string name);
        public abstract void Receive();

    }
}
