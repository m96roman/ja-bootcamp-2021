using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShypturTask5
{
    public abstract class Figura : IDrawable
    {
        public int LengthA { get; set; }
        public int LengthB { get; set; }
        public abstract void Draw();
    }
}
