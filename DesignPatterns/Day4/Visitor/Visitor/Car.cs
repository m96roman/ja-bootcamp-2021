using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Car : IComponent
    {   
        public long SerialNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public Date Date  { get; set; }

        public Car() 
        { 
        }

        public void InfoSerialize(IVisitor visitor)
        {
            visitor.VCar(this);
        }
    }
}
