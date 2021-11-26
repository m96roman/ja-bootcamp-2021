using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Stone
    {
        public double Even { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }
        public string Adress { get; set; }
        public Stone(double a, double b, double c,string adress)
        {
            Even = a;
            Width = b;
            Height = c;
            Adress = adress;
        }
    }
}
