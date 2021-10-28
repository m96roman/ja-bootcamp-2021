using System;
using System.IO;

namespace VDedenok_Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Task1-----");
            using (StreamWriter sw = new StreamWriter("TextToCountLinesFrom.txt"))
            {
                sw.WriteLine("This is line 1");
                sw.WriteLine("This is line 2");
                sw.WriteLine("This is line 3");
                sw.WriteLine("This is line 4");
                sw.WriteLine("This is line 5");
            }

            int linesCount = File.ReadAllLines("TextToCountLinesFrom.txt").Length;
            Console.WriteLine($"Number of lines in file is {linesCount}.");

            Console.WriteLine("------Task2------");
            string newline = "";
            int counter = 0;
            int indexOfFile = 0;
            string resulterText = "";
            string p = Directory.GetCurrentDirectory();
            string newFullPath = "";
          
            do
            {
                newline = Console.ReadLine();
                resulterText += newline;
                ++counter;
               
                if (counter == 2 )
                {
                    ++indexOfFile;
                    newFullPath = @$"{p}\inputFromVim{indexOfFile}.txt";
                    File.AppendAllText(newFullPath, resulterText);
                    resulterText = "";
                    counter = 0;
                }
            } 
            while (newline != "st");

            if (File.Exists(newFullPath))
            {
                Console.WriteLine("Last file exists.");
            }


            string[] files = Directory.GetFiles(@$"{p}", "*inputFromVim");
          
            foreach (var item in files)
            {
                Console.WriteLine(item);
            }
        }

    }
}
/*
            * 2. Write a program which reads input from Console infinitely long, with minor restrictions:
   - When user entered 8 lines of text you should write them in the file inputFromVIM{indexOfFile}.txt
   - For the next 8 lines write them in the next file inputFromVIM{indexOfFile + 1}.txt and so on.
BUT when user enters a stop word "LET ME OUT"(or anything else you like) you should do the following:
   - Make sure that last file inputFromVim{indexOfFile}.txt is created
   - Move all the created files during the user session to folder Session_{DateTime}
            */