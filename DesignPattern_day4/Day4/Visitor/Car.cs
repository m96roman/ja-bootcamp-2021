using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
   public class Car : IMember
    {
       
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public string Brand { get; set; }

        public void Accept(IConvert convert)
        {
            convert.ConvertCar(this);
        }
    }
}
