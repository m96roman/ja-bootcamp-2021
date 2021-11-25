using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Expert expert = new Expert(new WallpaperDecorator());
            expert.Decorate();
            expert.Decorator = new PlasterDecorator();
            expert.Decorate();
            expert.Decorator = new DrawDecorator();
            expert.Decorate();
        }
    }
}
