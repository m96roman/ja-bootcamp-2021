using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Task2
    {
        public void task2()
        {
            Console.Write("Input the string:");
            var input = (Console.ReadLine()).ToCharArray();
            var solution = input.GroupBy(str => str);

            foreach (var item in solution)
            {
                Console.WriteLine($"Character {item.Key}: {item.Count()} times");
            }
        }
    }
}
