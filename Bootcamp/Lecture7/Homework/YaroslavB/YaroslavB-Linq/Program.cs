using System;
using System.Linq;

namespace YaroslavB_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.  Write a program in C# Sharp to find the number of an array and the square of each number.
            Console.WriteLine("Subtask 1:\n");
            Console.WriteLine("Output:");

            var array = new int[] { 9, 8, 6, 5 };
            var newArr = array.Select(n => new { Number = n, SqrNo = Math.Pow(n, 2) });

            foreach (var item in newArr)
            {
                Console.WriteLine("{" + $" {nameof(item.Number)} = {item.Number}, {nameof(item.SqrNo)} = {item.SqrNo} " + "}");
            }

            Console.WriteLine("\n\nPress \'Enter\' to exit");
            Console.ReadLine();
        }
    }
}
