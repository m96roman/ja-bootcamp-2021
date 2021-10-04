using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShypturTask5
{
    public class Rectangle : Figura
    {
        public Rectangle(int a, int b)
        {
            LengthA = a;
            LengthB = b;
        }
        public override void Draw()
        {
            Console.WriteLine($"Perimetr= {  (LengthA + LengthB) * 2} ;");
        }
    }
}
