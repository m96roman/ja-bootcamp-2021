using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Designer designerDay1 = new Designer(new DecorateWithLamp());
            designerDay1.PaintWalls();
            designerDay1.HangWallpaper();
            designerDay1.DecorateWall();
          
            Designer designerDay2 = new Designer(new DecorateWithMirror());
            designerDay2.DecorateWall();
           
            Designer designerDay3 = new Designer(new DecorateWithPicture());
            designerDay3.DecorateWall();
        }
    }
}
