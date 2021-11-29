using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class Car : IElement
    {
        public string Model { get; set; }
        public int Number { get; set; }
        public string Color { get; set; }

        public int Year { get; set; }
        public string Brand { get; set; }

        public void Show(IVisitor visitor)
        {
            visitor.VisitCar(this);
        }
    }
}
