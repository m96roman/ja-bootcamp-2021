using System;

namespace YaroslavB_Task5
{
    public struct Point : IDrawable
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Draw()
        {
            Console.WriteLine($"Drawn simple point with coordinates: X - {X}, Y - {Y}");
        }

        public void DrawVertex(string vertexName)
        {
            Console.WriteLine($"\tvertex {vertexName} - {X},{Y}");
        }
    }

}
