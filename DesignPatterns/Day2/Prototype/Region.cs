using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    [Serializable]
    public class Region
    {
        public string Name { get; set; }
        public int Square { get; set; }
        public Region(string name, int square)
        {
            Name = name;
            Square = square;
        }
    }
}
