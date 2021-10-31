using System;
using System.Collections.Generic;
using System.IO;

namespace VDedenok_Task9
{
    class Task2
    {
        public void RunTask2()
        {
            Console.WriteLine("Enter some text at least 8 times:");
            Console.WriteLine("To finish program enter \"stop\".");

            int counter = 0;
            int indexOfFile = 0;
         
            string lineFromInput;
            string resulterText = "";
          
            string directoryPath = Directory.GetCurrentDirectory();
            string newFullPath;
            string folderPath = @$"{directoryPath}\FolderInputFromVim";

            List<string> createdFilesPathes = new List<string>();

            do
            {
                lineFromInput = Console.ReadLine();
              
                if (lineFromInput == "stop")
                {
                    ++indexOfFile;

                    newFullPath = @$"{directoryPath}\inputFromVim{indexOfFile}.txt";

                    File.AppendAllText(newFullPath, resulterText);

                    createdFilesPathes.Add(@$"\inputFromVim{indexOfFile}.txt");
                }

                resulterText += lineFromInput;
                ++counter;

                if (counter == 8)
                {
                    ++indexOfFile;
                   
                    newFullPath = @$"{directoryPath}\inputFromVim{indexOfFile}.txt";
                  
                    File.AppendAllText(newFullPath, resulterText);
                   
                    resulterText = "";
                   
                    counter = 0;
                   
                    createdFilesPathes.Add(@$"\inputFromVim{indexOfFile}.txt");
                } 
            }

            while (lineFromInput != "stop");

            foreach (var path in createdFilesPathes)
            {
                Directory.CreateDirectory(folderPath);

                string destinationPath = @$"{directoryPath}\FolderInputFromVim\{path}";

                File.Move(@$"{directoryPath}\{path}", destinationPath, true);
            }
        }
    }
}
