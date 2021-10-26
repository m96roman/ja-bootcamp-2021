using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ADovhanych_Task9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = new();
            int indexOfFile = 0;
            string input = "";

            while (input != "STOP THE COUNT")
            {
                input = Console.ReadLine();

                if (inputList.Count == 8)
                {
                    using (StreamWriter streamWriter = new StreamWriter($"inputFromVIM{indexOfFile}.txt"))
                    {
                        foreach (var item in inputList)
                        {
                            streamWriter.WriteLine(item);
                        }
                        indexOfFile++;
                        inputList.RemoveRange(0, inputList.Count);
                    }  
                }
                else
                {
                    inputList.Add(input);
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
            string currentDirectory = Directory.GetCurrentDirectory();
            string path = Path.Combine(currentDirectory, $"Session_{DateTime.Now.ToString("MM/dd/yyyy hh-mm-tt")}");

            try
            {
                DirectoryInfo directoryInfo = Directory.CreateDirectory(path);
                string[] files = Directory.GetFiles(currentDirectory, "*.txt");

                foreach (var item in files)

                {
                    if (Path.GetFileName(item).Contains($"inputFromVIM"))
                    {
                        var fileName = Path.GetFileName(item);
                        var comnbinedPath = Path.Combine(path, fileName);
                        File.Move(item, comnbinedPath, true);
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
