using System;
using System.IO;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = File.ReadLines(@"C:\Projects\Lecture 9 .Net\Task1\TestFile.txt").Count();
            Console.WriteLine($"number of lines in a file 'TestFile.txt' -> { numbers }");
        }
    }
}
