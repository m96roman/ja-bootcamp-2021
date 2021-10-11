using System;
using System.Collections.Generic;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Enter strings--");
            Console.WriteLine("If you want STOP, write 'LET ME OUT'");

            StartReadinputs();    
        }

        static void StartReadinputs()
        {
            bool letMeOut = false;
            int counterStrings = 0;
            int indexOfFile = 0;
            List<string> strings = new List<string>();

            do
            {
                string str = Console.ReadLine();

                if (str != "LET ME OUT")
                {
                    strings.Add(str);
                    counterStrings++;
                }
                else
                {
                    indexOfFile++;
                    CreateFileAndWriteStrings(indexOfFile, strings);

                    MoveToNewDirectory(indexOfFile);
                    letMeOut = true;
                }

                if (counterStrings == 8)
                {
                    indexOfFile++;
                    counterStrings = 0;

                    CreateFileAndWriteStrings(indexOfFile, strings);
                }
            } while (!letMeOut);
        }

        static void CreateFileAndWriteStrings(int indexOfFile, List<string> strings )
        {
            foreach (var item in strings)
            {
                File.WriteAllText($@"{Directory.GetCurrentDirectory()}inputfromvim{indexOfFile}.txt", item);
            }
        }

        static void MoveToNewDirectory(int indexOfFile)
        {
            bool isLastFileCreated = File.Exists($@"{Directory.GetCurrentDirectory()}inputfromvim{indexOfFile}.txt");

            if (isLastFileCreated)
            {
                Console.WriteLine("Last file is created!");

                var directory = Directory.CreateDirectory($@"{Directory.GetCurrentDirectory()}Session_{DateTime.Now.ToString("dddd dd MMMM yyyy")}");

                if (Directory.Exists(directory.FullName))
                {
                    foreach (var file in new DirectoryInfo(@"{Directory.GetCurrentDirectory()}").GetFiles("*.txt"))
                    {
                        file.MoveTo($@"{directory}\{file.Name}");
                    }
                    Console.WriteLine("All file are moved into new directory!");
                }
            }
        }
    }
}
