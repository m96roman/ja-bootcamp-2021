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

            Console.WriteLine("\n-------------------------------------------------------------------\n");


            //2.  Write a program in C# Sharp to display the characters and frequency of character from giving string.
            Console.WriteLine("\nSubtask 2:\n");
            Console.WriteLine("Output:");

            string inputString = "apple";

            Char[] chars = inputString.ToCharArray();
            var charsFeq = chars.GroupBy(c => c).Select(g => new { Char = g.Key, Frequency = g.Count() });

            foreach (var item in charsFeq)
            {
                Console.WriteLine($"Character {item.Char}: {item.Frequency} times");
            }

            Console.WriteLine("\n-------------------------------------------------------------------\n");


            //3. Write a program in C# Sharp to convert a string array to a string.
            Console.WriteLine("\nSubtask 3:\n");
            Console.WriteLine("Output:");

            var animals = new string[] { "cat", "dog", "rat" };
            var animalsString = animals.Aggregate((x, y) => x + ", " + y);

            Console.WriteLine(animalsString);

            Console.WriteLine("\n-------------------------------------------------------------------\n");



            Console.WriteLine("\n\nPress \'Enter\' to exit");
            Console.ReadLine();
        }
    }
}
