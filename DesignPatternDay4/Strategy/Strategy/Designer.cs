using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Designer
    {
        public IDecorate decorator;
        public Designer(IDecorate decor)
        {
            this.decorator = decor;
        }
        public void PaintWalls()
        {
            Console.WriteLine("I paint wassl.");
        }
        public void HangWallpaper()
        {
            Console.WriteLine("I hang wallpapers.");
        }
        public void DecorateWall()
        {
            decorator.DecorateWall();
        }
    }
}
