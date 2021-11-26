using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class WallpaperGlue : IDecorator
    {
        public void Decorate()
        {
            Console.WriteLine("Wallpapers are glued");
        }
    }
}
