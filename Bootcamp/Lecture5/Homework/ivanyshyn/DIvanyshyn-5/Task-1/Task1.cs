using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIvanyshyn_5.Task_1
{
    /// <summary>
    ///Create generic method that accepts collection of drawable objects.
    ///Drawable object can be Point, Rectangle, Circle.   
    ///You should be able to call function with different set of arguments like List<Point>, Rectangle[]
    ///Show at least two examples of usage of this function.
    /// </summary>
    internal class Task1
    {
        public static void Execute()
        {
            Console.WriteLine(new string('-', 20));
            DrawObjects(new List<Point> { new(), new(), new() });

            Console.WriteLine(new string('-', 20));
            DrawObjects(new Circle[] { new(), new(), new() });

            Console.WriteLine(new string('-', 20));
            DrawObjects(new List<Rectangle> { new(), new(), new() });
        }

        private static void DrawObjects<T>(IEnumerable<T> drables) where T : IDrawable
        {
            Console.WriteLine(drables.GetType());
            foreach (var item in drables)
            {
                Console.WriteLine(item.Draw());
            }
        }

        //private static void DrawObjects(IEnumerable<IDrawable> drawables) would do the same job)
    }
}
