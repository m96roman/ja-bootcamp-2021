using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class City: IClone
    {
        public string NameCity { get; set; }
        public int Population { get; set; }

        public object clone()
        {
            return this.MemberwiseClone();
        }
    }
}
