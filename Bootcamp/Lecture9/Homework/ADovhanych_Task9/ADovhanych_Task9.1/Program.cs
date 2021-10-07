using System;
using System.IO;
using System.Linq;

namespace ADovhanych_Task9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter streamWriter = new("line_numbers.txt"))
            {
                streamWriter.WriteLine("first line");
                streamWriter.WriteLine("second line");
                streamWriter.WriteLine("third line");
                streamWriter.WriteLine("fourth line");
            }

            int countLines = File.ReadLines("line_numbers.txt").Count();
            Console.WriteLine($"Number of lines {countLines}");
        }
    }
}
