using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Task_1
{
    class Task1
    {
        public static void FindNumber()
        {
            int[] numbers = new int[]
               {1,2,3,4,54,5,6,7,78};

            var res = numbers.Select(n => new { num = n, sqrt = Math.Pow(n, 2) }).ToList();
            Console.WriteLine(string.Join(", ", res));
        }
    }
}
