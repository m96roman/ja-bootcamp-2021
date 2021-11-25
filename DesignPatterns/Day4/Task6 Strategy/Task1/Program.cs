using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Expert expert = new Expert("John", new Paint());
            Expert expert2 = new Expert("John", new Plaster());
            Expert expert3 = new Expert("John", new WallpaperGlue());

            expert.Decorate();
            expert2.Decorate();
            expert3.Decorate();

        }
    }
}
