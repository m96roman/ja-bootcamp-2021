using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public interface IDrivable // extracted interface from Car class
    {
        void GoForward();
        void TurnLeft();
        void TurnRight();
        void GoBackward();
    }
}
