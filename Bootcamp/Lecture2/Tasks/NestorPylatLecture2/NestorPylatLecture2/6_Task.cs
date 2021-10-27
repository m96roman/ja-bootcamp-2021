using System;
using System.Collections.Generic;
using System.Text;

namespace NestorPylatLecture2
{
    class _6_Task
    {
         static public void returnStr(int num1, int num2)
        {
           

            Console.WriteLine($"Now the 1st number is : {num1} , and the 2nd number is : {num2}");
        }
        public static void doTask6()
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            returnStr(num1, num2);
        }



    }
}
