using System;
using System.Collections.Generic;
using System.IO;

namespace ADovhanych_Task9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = new();
            int counter = 0;
            int indexOfFile = 0;
            string input = "";

            while (input != "STOP THE COUNT")
            {
                input = Console.ReadLine();

                if (counter == 8)
                {
                    using (StreamWriter streamWriter = new StreamWriter($"inputFromVIM{indexOfFile}.txt"))
                    {
                        foreach (var item in inputList)
                        {
                            streamWriter.WriteLine(item);
                        }
                        indexOfFile++;
                        counter = 0;
                        inputList.RemoveRange(0, inputList.Count);
                    }  
                }
                else
                {
                    inputList.Add(input);
                    counter++;
                }
            }

            if(inputList.Count != 0)
            {
                using (StreamWriter streamWriter = new($"inputFromVIM{indexOfFile}.txt"))
                {
                    foreach (var item in inputList)
                    {
                        streamWriter.WriteLine(item);
                    }

                    streamWriter.Flush();
                }
            }

            MoveFolder();
        }

        public static void MoveFolder()
        {
            string newDirectory = Directory.GetCurrentDirectory();
            string path = $@"{newDirectory}{DateTime.Now}";

            try
            {
                if (Directory.Exists(path))
                {
                    Console.WriteLine("Folder already exist");
                    throw new Exception("Folder already exist");
                }

                DirectoryInfo directoryInfo = Directory.CreateDirectory(path);
                string[] files = Directory.GetFiles(newDirectory);

                foreach (var item in files)
                {
                    if (Path.GetFileName(item).Contains($"inputFromVim"))
                    {
                        var fileName = Path.GetFileName(item);
                        var comninedPath = Path.Combine(path, fileName);
                        File.Move(item, comninedPath, true);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
