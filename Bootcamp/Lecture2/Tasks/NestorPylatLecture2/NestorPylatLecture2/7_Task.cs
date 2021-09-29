using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NestorPylatLecture2
{
    public struct Point
    {
        public int X;
        public int Y;
        public Point(int x, int y)
        {
            X = x;
            Y = y;


        }
        public string PrintPoint()
        {
            return ($"({X}, {Y})");
        }
    }



    class _7_Task
    {
        public static bool TryParse(string str, out Point? point)
        {
            string[] devidedByComa;
            devidedByComa = str.Split(",");
            if (devidedByComa.Length == 2)
            {
                bool isXInt = Int32.TryParse(devidedByComa[0], out int x);
                bool isYInt = Int32.TryParse(devidedByComa[1], out int y);
                if (isXInt && isYInt )
                {
                    point = new Point(x,y);
                    return true;
                    
                }
                
            }
            point = null;
            return false;
        }
        public static void doTask7()
        {
            Console.WriteLine($" - Input your point:");
            string str = Console.ReadLine();


          

            if (TryParse(str, out Point? point))
            {
                Console.WriteLine($"- Result of parsing: true, Point = {point.Value.PrintPoint()} ");
            }
            else Console.WriteLine($"- Result of parsing: false, Point = undefined");
          





        }
    }

  
}


