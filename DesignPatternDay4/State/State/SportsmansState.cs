using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public abstract class SportsmansState
    {  
        public abstract void ChangeAction(Sportsman sportsman);
    }
}
