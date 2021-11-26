using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class BaseShip
    {
        protected IMediator _mediator;

        public BaseShip(IMediator mediator=null)
        {
            _mediator = mediator;
        }
        public void SetShip(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
