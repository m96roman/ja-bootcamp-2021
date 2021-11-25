using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal interface IVisitor
    {
        void VisitDriver(Driver driver);
        void VisitCar(Car car);
    }
}
