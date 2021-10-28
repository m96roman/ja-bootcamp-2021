using System;
using System.Collections.Generic;

namespace YaroslavB_Task5
{
    class Designer
    {
        static void Draw<T>(IEnumerable<T> collection, T num) where T : struct
        {
            foreach (var item in collection)
            {
                Console.WriteLine($"Collection: {item}");
            }
        }

        public static void Draw<T>(IEnumerable<T> shapeCollection) where T: IDrawable
        {
            int counter = 1;

            foreach (var shape in shapeCollection)
            {
                Console.WriteLine($"\nDrawing shape number {counter} in the collection of {shape.GetType().Name}s");
                shape.Draw();
                counter++;
            }
        }
    }
}

