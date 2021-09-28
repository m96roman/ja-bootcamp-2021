using System;
using System.Collections.Generic;
using System.Text;

namespace NestorPylatLecture2
{
    class _5_Task
    {
        public static void doTask5()
        {
            int nArray = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(nArray);
            int[] array = new int[nArray];
            int count = 0;

            for (int i = 0; i < nArray; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());               
          
                    }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                        
                    }
                }
            }

            Console.WriteLine(count);


        }
    }
}
