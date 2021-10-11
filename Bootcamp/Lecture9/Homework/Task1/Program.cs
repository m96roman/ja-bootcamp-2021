using System;
using System.IO;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = File.ReadLines($@"C:\src\ja-bootcamp-2021\Bootcamp\Lecture9\Homework\Tasks.txt").Count();
            Console.WriteLine($"number of lines in a file 'Task.txt' -> { numbers }");
        }
    }
}
