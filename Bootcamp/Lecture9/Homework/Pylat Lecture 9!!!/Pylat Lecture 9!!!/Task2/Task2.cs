using Microsoft.OData.Edm;
using System;
using System.IO;


namespace Pylat_Lecture_9_Task_1
{
    public class Task2
    {
        public static void StartProgram()
        {
            var fileNumber = 1;
            var strNumber = 0;
            string text = "";
            bool Out = false;
            string pathToCreate = $@"C:\Users\nestor.pylat\ja-bootcamp-2021\Bootcamp\Lecture9\Homework\Pylat Lecture 9!!!\Pylat Lecture 9!!!\TextTask2{fileNumber}.txt";
            string pathToMove = $@"C:\Users\nestor.pylat\ja-bootcamp-2021\Bootcamp\Lecture9\Homework\Pylat Lecture 9!!!\Pylat Lecture 9!!!\Session_{Date.Now}";

            do
            {
                var oneLine = Console.ReadLine();

                if (fileNumber < 3 && oneLine != "LET ME OUT")
                {
                    text = text + oneLine + "\n";
                    strNumber++;

                    if (strNumber % 8 == 0)
                    {
                        CreateFile(text, fileNumber, pathToCreate);
                        if (!File.Exists(pathToMove))
                        {
                            Directory.CreateDirectory(pathToMove);
                        }

                        File.Move(pathToCreate, pathToMove + $@"\Task2{fileNumber}.txt");
                        fileNumber++;
                    }
                }

                else
                {
                    CreateFile(text, fileNumber, pathToCreate);
                    if (File.Exists(pathToCreate))
                    {
                        Console.WriteLine("File is created");
                    }

                    Out = true;
                    break;
                }
            }

            while (Out == false);
        }

        static void CreateFile(string str, int indexOfFile, string pathToCreate)
        {
            File.WriteAllText(pathToCreate, str);
            Console.Clear();
        }
    }
}

