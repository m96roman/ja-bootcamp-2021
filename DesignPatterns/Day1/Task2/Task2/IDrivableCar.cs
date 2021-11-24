using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public interface IDrivableCar: IDrivableTrain // extracted interface from Car class
    {
        void TurnLeft();
        void TurnRight();
       }
}
