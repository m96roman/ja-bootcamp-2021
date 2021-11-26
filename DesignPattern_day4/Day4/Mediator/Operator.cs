using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
   public class Operator:IMediator
    {
        private UzhShip _uzhShip;
        private LvivShip _lvivShip;
        private KyivShip _kyivShip;

        public Operator(UzhShip uzhShip, LvivShip lvivShip, KyivShip kyivShip)
        {
            _uzhShip = uzhShip;
            _lvivShip = lvivShip;
            _kyivShip = kyivShip;
        }

        public void Notify(BaseShip sender)
        {
            if (sender.GetType()==typeof(UzhShip))
            {
                this._kyivShip.SendFromUzh();
                this._lvivShip.SendFromUzh();
            }
            else if (sender.GetType() == typeof(LvivShip))
            {
                this._kyivShip.SendFromLviv();
                this._uzhShip.SendFromLviv();
            }
            else
            {
                this._lvivShip.SendFromKyiv();
                this._uzhShip.SendFromKyiv();
            }
        }
    }
}
