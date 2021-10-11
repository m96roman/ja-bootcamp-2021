using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pylat_Lecture_9_Task_1
{
    public class Task2
    {
        public static void doTask2()
        {
            StartProgram();
        }

        public static void StartProgram()
        {
            var fileNumber = 0;
            var strNumber = 0;
            var strings = new List<string>();
            bool Out = true;

            do
            {
                var oneLine = Console.ReadLine();

                if (oneLine == "LET ME OUT" || fileNumber == 2)
                {
                    Console.WriteLine("smth");
                    Out = false;
                }
                else
                {
                    strings.Add(oneLine);
                    strNumber++;
                }

                if (strNumber % 8 == 0)
                {
                    fileNumber++;
                    CreateFile(fileNumber, strings);
                }
            }
            while (Out);
        }

        static void CreateFile(int fileNumber, List<string> strings)
        {
            using (var creator = File.Create($@"C:\Users\Admin\Desktop\Pylat Lecture 9 Task 1\Pylat Lecture 9 Task 1\bin\Debug\netcoreapp3.1\task2File{fileNumber}.txt")) 
            using (StreamWriter writeLine = new StreamWriter($@"C:\Users\Admin\Desktop\Pylat Lecture 9 Task 1\Pylat Lecture 9 Task 1\bin\Debug\netcoreapp3.1\task2File{fileNumber}.txt"))
            {
                foreach (var item in strings)
                {
                    writeLine.WriteLine(item);
                }
            }
        }
    }
}

