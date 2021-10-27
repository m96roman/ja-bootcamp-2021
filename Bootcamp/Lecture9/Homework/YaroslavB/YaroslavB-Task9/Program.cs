using System;
using System.IO;

namespace YaroslavB_Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Write a program to count the number of lines in a file
            CountFileLines();

            Console.WriteLine("\n-----------------Prass any key to move to Subtask 2-----------------\n");
            Console.ReadKey();

            //2. Write a program which reads input from Console infinitely long
            VIMConsole.StartVIMconsole();

            Console.WriteLine("\n-----------------Prass any key to move to Subtask 3-----------------\n");
            Console.ReadKey();

            //3. Write a program which tracks students attendance
            University.SemesterEmulation(Deanery.GetStudents());
            University.ShowAttendingResults();

            Console.WriteLine("\n-----------------Prass any key to move to Subtask 4-----------------\n");
            Console.ReadKey();

            //4*. Example with phones, emergency test, You should log every
            // exception that happens during execution into log file
            TestEmergencyHelper.RunTest();

            Console.WriteLine("\n----------------------------------\n");
            Console.WriteLine("Press \'Enter\' to exit...");
            Console.ReadLine();
        }

        #region Subtask 1

        private static void CountFileLines()
        {
            string fileName = "Program.cs";     
            string filePath = $"..\\..\\..\\{fileName}";

            int numberOfLines = GetNumberOfFileLines(filePath, out bool status);
 
            if (!status)
            {
                Console.WriteLine("Error! Wrong file path or missing file.");
                return;
            }

            Console.WriteLine($"Number of lines in the file: \'{fileName}\' - {numberOfLines}");
        }

        private static int GetNumberOfFileLines(string filePath, out bool status)
        {
            status = true;
            bool fileExists = File.Exists(filePath);

            if (!fileExists)
            {
                status = false;
                return 0;
            }

            string[] file = File.ReadAllLines(filePath);

            return file.Length;
        }

        #endregion

    }
}
