using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIvanyshyn_9.FileCounter
{
    public class Task1
    {
        internal static void Execute()
        {
            Console.WriteLine("Enter path to file:");

            string filePath = "";
            do
            {
                if (filePath != "")
                {
                    Console.WriteLine("Enter valid path to file");
                }

                filePath = Console.ReadLine();
            } while (!File.Exists(filePath));

            Console.WriteLine($"Count of lines in file {filePath} is {File.ReadLines(filePath).Count()}");
        }
    }
}
