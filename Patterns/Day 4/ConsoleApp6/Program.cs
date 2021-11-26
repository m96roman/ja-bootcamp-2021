using ConsoleApp6.Decors;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Strategy */

            Expert expert = new Expert(new PaintDecor());

            expert.Decorate();

            expert.Decor = new WallpaperDecor();

            expert.Decorate();

            expert.Decor = new StuccoDecor();

            expert.Decorate();
        }
    }
}
