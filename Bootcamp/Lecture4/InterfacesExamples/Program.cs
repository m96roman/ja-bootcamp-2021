using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace CollectionInitializationExample
{
    public abstract class Draw
    {
        protected string hmmmm = "hmmm";

        public abstract void DrawMe();
    }

    abstract class Moveable
    {
        public abstract void MoveByX(int x);
    }

    interface IDraw
    {
        void DrawMe();
    }

    interface IDraw3D
    {
        void DrawMe();
    }

    interface IMoveable
    {
        void MoveByX(int x);
    }

    public class Point : IDraw, IDraw3D, IMoveable
    {
        public int X { get; set; }
        public int Y { get; set; }


        public void DrawMe()
        {
            Console.WriteLine((X, Y).ToString());
        }

        void IDraw3D.DrawMe()
        {
            Console.WriteLine($"Fancy 3D point: {(X, Y)}");
        }

        public void MoveByX(int x)
        {
            this.X += x;
        }
    }

    public class Square : IDraw
    {
        public int Length { get; set; }

        public void DrawMe()
        {
            Console.WriteLine($"I'm squre with lenght: {Length}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //CustomInterfaceExamples.ShowExample();
            //InterfaceHierarchyExamples.ShowExample();
            //InterfacesNamingProblemExamples.ShowExample();

            var point = new Point
            {
                X = 8,
                Y = 88
            };

            point.DrawMe();
            ((IDraw3D)point).DrawMe();
            point.MoveByX(5);
            point.DrawMe();

            var square = new Square { Length = 8 };

            var drawableFigures = new IDraw[] { point, square };

            foreach (var item in drawableFigures)
            {
                IMoveable movableWithAs = item as IMoveable;

                if (movableWithAs != null)
                {
                    movableWithAs.MoveByX(8);
                }

                if (item is IMoveable moveable)
                {
                    moveable.MoveByX(8);
                }

                if (item is IDraw3D draw3D)
                {
                    DrawFancy3D(draw3D);
                }

                item.DrawMe();
            }

            Console.Read();
        }

        public static void DrawFancy3D(IDraw3D draw)
            => draw.DrawMe();
    }


}
