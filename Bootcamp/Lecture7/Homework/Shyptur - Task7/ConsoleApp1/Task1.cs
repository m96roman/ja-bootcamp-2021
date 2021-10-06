using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Task1
    {
        public void task1()
        {
            int[] arrayint = new int[] { 2, 3, 5, 6, 78, 8 };

            var a = arrayint.Select(b => new { Number = b, SqrNo=b*b  });

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}
