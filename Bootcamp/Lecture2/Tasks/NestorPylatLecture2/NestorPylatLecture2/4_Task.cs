using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NestorPylatLecture2
{
    class _4_Task
    {
        public static void doTask4()
        {
            int nArray = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[nArray];

            for (int i = 0; i < nArray; i++) {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(string.Join(",", array));
            Array.Reverse(array);
            Console.WriteLine(string.Join(",", array));
             

        } 
    }
}
