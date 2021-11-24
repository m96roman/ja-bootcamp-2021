using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public abstract class IDrivable 
    {
        public virtual void GoForward() { }
        public virtual void TurnLeft() { }
        public virtual void TurnRight() { }
        public virtual void GoBackward() { }
    }
}
