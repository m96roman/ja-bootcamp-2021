using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Ships
{
    class UzhgorodShip : Ship
    {
        public UzhgorodShip(IMediator mediator) : base(mediator)  
        {
            this.Name = "UzhgorodShip";
        }
    }
}
