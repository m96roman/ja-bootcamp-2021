using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Region:IClone
    {
        public string NameRegion { get; set; }
        public double SquareRegion { get; set; }

        public object clone()
        {
            return this.MemberwiseClone();
        }
    }
}
