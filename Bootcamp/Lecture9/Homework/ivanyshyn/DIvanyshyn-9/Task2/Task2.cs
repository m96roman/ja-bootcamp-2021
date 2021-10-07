using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIvanyshyn_9.InfiniteLog
{
    class Task2
    {
        private static readonly char exitCharacter = 'E';
        private static string[] lines = new string[8];
        private static int indexOfFile = 0;

        internal static void Execute()
        {
            Console.WriteLine($" '{exitCharacter}' - for exit)");
            string input = "";
            int counter = 0;

            while (true)
            {

                input = Console.ReadLine();

                if (input.Length == 1 && input.ToUpper()[0].Equals(exitCharacter))
                {
                    break;
                }

                if (counter == 8)
                {
                    WriteToFile(indexOfFile, lines);

                    counter = 0;
                }

                lines[counter] = input;

                counter++;
            }

            if (counter != 0)
            {
                string[] lastLines = new string[counter];
                Array.Copy(lines, 0, lastLines, 0, counter);
                WriteToFile(indexOfFile, lastLines);
            }

            CleanUpAndMoveFiles();
        }

        private static void CleanUpAndMoveFiles()
        {
            var baseDirectory = Path.Combine(Directory.GetCurrentDirectory(), "temp");
            var destinationDirectory = 
                Path.Combine(Directory.GetCurrentDirectory(), $"Session_{DateTime.Now.ToString("yyyy'-'MM'-'dd' Time 'HH'-'mm'-'ss")}");

            Directory.Move(baseDirectory, destinationDirectory);

            Console.WriteLine($"*Note to check directory go to= {destinationDirectory}");
        }

        private static void WriteToFile(int indexOfFile, string[] lines)
        {
            var tempVimFilesDirectory = Path.Combine(Directory.GetCurrentDirectory(), "temp");

            if (!Directory.Exists(tempVimFilesDirectory))
            {
                Directory.CreateDirectory(tempVimFilesDirectory);
            }

            var TempFilePath = Path.Combine(tempVimFilesDirectory, $"inputFromVIM{indexOfFile}.txt");

            File.WriteAllLines(TempFilePath, lines);
        }
    }
}
