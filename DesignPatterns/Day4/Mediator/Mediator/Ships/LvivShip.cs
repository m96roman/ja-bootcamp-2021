using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Ships
{
    class LvivShip : Ship
    {
        public LvivShip(IMediator mediator) : base(mediator)
        {
            this.Name = "LvivShip";
        }
    }
}
