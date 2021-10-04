using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShypturTask5
{
    public class Square : Figura
    {
        public Square(int x)
        {
            LengthA = x;
            LengthB = x;
        }
        public override void Draw()
        {
            Console.WriteLine($"Perimetr= {  LengthA * 4} ;");
        }
    }
}
