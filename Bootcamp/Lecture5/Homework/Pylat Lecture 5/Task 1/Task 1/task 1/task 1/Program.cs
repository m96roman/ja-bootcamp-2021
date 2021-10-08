using System;
using System.Collections;
using System.Collections.Generic;

namespace task_5
{
    class Program
    {


        static void Main(string[] args)
        {
            var list = new List<ForAll>() { new Point(3), new Rectangle(2), new Circle(4) };
            DrawAll<ForAll>(list);



        }

        public static void DrawAll<T>(IEnumerable<T> collection) where T : ForAll
        {
            foreach (var item in collection)
            {
                item.Draw();
            }
        }
    }
}