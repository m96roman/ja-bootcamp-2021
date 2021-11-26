using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    abstract class SportsmanState
    {
       
        public abstract void Run(Sportsman sportsman);
        public abstract void Walk(Sportsman sportsman);
        public abstract void Stand(Sportsman sportsman);
    }
}
