using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Pylat_Lecture_9_Task_1
{
    class Task1
    {
        public static string CreateFileTxt()
        {
            var directory = Directory.GetCurrentDirectory();
            Console.WriteLine(directory);
            using (var newFile = File.Create($"{directory}\\PylatLecture9")) {
                using (var writer = new StreamWriter(newFile))
                {
                    writer.WriteLine(@"Text text text text
                                   Text text text text
                                   Text text text text
                                   Text text text text
                                   Text text text text
                                   Text text text text
                                   Text text text text
                                   Text text text text
                                   Text text text text
                                   Text text text text
                                   Text text text text
                                   Text text text text ");

                    return newFile.Name;
                } 
            }  
        }

        public static int CountLineInFile(string file)
        {
            var lineCounter = 0;
            using (var reader = new StreamReader(file))
            {
                while (reader.ReadLine() != null)
                {
                    lineCounter++;
                }
            }
            return lineCounter;
        }
    }
}

