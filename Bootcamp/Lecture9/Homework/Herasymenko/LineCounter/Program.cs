using System;
using System.IO;

namespace LineCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentPath = Directory.GetCurrentDirectory();
            var currentFile = @$"{currentPath}\file.txt";
            var linesCount = CountLiner(currentFile);

            Console.WriteLine(linesCount);

        }

        public static long CountLiner(string file)
        {
            if(!File.Exists(file))
            {
                throw new Exception("The file doesn't exists");
            }

            var lineCounter = 0L;

            using (var reader = new StreamReader(file))
            {
                while (reader.ReadLine() != null)
                {
                    lineCounter++;
                }
                return lineCounter;
            }
        }
    }
}
