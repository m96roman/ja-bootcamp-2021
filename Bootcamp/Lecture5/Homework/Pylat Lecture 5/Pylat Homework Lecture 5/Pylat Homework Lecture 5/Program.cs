using System;
using System.Collections;
using System.Collections.Generic;

namespace Pylat_Homework_Lecture_5
{
    class Program
    {
       public  interface IForAllFigure
        {
            void Draw();
        }

        public class Point: IForAllFigure
        {
            List<int> NPoint { get; set; }

            public void Draw()
            {
                Console.WriteLine($"{NPoint} is done");
            }
        }

        public class Rectangle: IForAllFigure
        {
            List<int> NRectangle { get; set; }

            public void Draw()
            {
                Console.WriteLine($"{NRectangle} is done");
            }
        }

        public class Circle: IForAllFigure
        {
            List<int> NCircle { get; set; }

            public void Draw()
            {
                Console.WriteLine($"{NCircle} is done");
            }
        }

        static void Main(string[] args)
        {


``

        }

        public void Add<T>(T figure) where T : IForAllFigure
        {
            figure.Draw();

        }


    }
}
