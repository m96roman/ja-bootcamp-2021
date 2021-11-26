using System;
using System.Collections.Generic;
using System.Text;

namespace Task5_Mediator
{
    public class BaseShip
    {
        public IMediator _mediator;

        public BaseShip(IMediator mediator = null)
        {
            _mediator = mediator;
        }

        public void ChangeShip(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
