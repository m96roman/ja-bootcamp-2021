using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Region : Prototype
    {
        public string Name { get; set; }
        public int Square { get; set; }
        public Region(string name, int square)
        {
            Name = name;
            Square = square;
        }

        public override Prototype Copy()
        {
            var clone = (Region)this.MemberwiseClone();
            clone.Name = string.Copy(Name);
            return clone;
        }

    }
}
