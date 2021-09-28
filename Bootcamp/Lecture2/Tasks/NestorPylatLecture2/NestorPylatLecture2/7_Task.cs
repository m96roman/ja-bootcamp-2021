using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NestorPylatLecture2
{
    public struct Point
    {
        public int x;
        public int y;
        public Point(int X, int Y)
        {
            int nArray = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[nArray];

            for (int i = 0; i < nArray; i++)
            {
                try
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                    String.Join(",", array);
                    Console.WriteLine(array);
                }
                catch
                {
                    Console.WriteLine("not a Number");
                }
                {

                }
            }

            x = X;
            y = Y;

        }
        public void Func()

        {
            Console.WriteLine()
        
    } }

    class _7_Task
    {

        public static void doTask7()
        {

        }
    }
}
