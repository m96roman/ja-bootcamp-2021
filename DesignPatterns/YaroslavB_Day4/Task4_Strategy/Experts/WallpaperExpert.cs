using System;

namespace Task4_Strategy
{
    class WallpaperExpert : IExpert
    {
        public void Decorate()
        {
            Console.WriteLine("Glued wallpaper on the wall.");
        }
    }
}
