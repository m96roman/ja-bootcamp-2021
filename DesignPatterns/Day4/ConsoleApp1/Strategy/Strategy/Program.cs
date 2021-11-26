using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            PaintWalls paint = new PaintWalls();
            DecoratingMan man = new DecoratingMan(paint);

            man.DecorateWalls();
        }
    }
}
