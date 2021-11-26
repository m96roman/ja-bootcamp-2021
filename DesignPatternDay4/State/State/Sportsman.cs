using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Sportsman
    {
        public SportsmansState State { get; set; }
        public Sportsman(SportsmansState spState)
        {
            this.State = spState;
        }
        public void RequesteChange()
        {
            this.State.ChangeAction(this);
        }
    }
}
