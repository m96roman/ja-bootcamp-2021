using System;
using ConsoleApp6.Interfaces;

namespace ConsoleApp6.Decors
{
    public class WallpaperDecor : IDecorate
    {
        public void Decorate()
        {
            Console.WriteLine("Expert glue wallpaper");
        }
    }
}
