using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;

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
            /*
           Console.WriteLine("------Task2------");

           string lintFromInput = "";
           int counter = 0;
           int indexOfFile = 0;
           string resulterText = "";
           string p = Directory.GetCurrentDirectory();
           string newFullPath = "";
           string folderPath = @$"{p}\FolderInputFromVim";

           List<string> pathes= new List<string>();

           do
           {
               lintFromInput = Console.ReadLine();
               resulterText += lintFromInput;
               ++counter;

               if (counter == 2) 
               {
                   ++indexOfFile;
                   newFullPath = @$"{p}\inputFromVim{indexOfFile}.txt";
                   File.AppendAllText(newFullPath, resulterText);
                   resulterText = "";
                   counter = 0;
                   pathes.Add(@$"\inputFromVim{indexOfFile}.txt");
               }
           } 
           while (lintFromInput != "stop");


           if (File.Exists(newFullPath))
           {
               Console.WriteLine("Last file exists!");
           }

           foreach(var path in pathes)
           {
               Directory.CreateDirectory(folderPath); 

               string destinationPath = @$"{p}\FolderInputFromVim\{path}";

               File.Move(@$"{p}\{path}", destinationPath);
           }
         */
             List<Student> students = new List<Student>() 
             {
              new Student() { Name = "Vika", LecturesAttended = 11},
              new Student() { Name = "Olya", LecturesAttended = 12},
              new Student() { Name = "Nadiya", LecturesAttended = 13},
              new Student() { Name = "Marina", LecturesAttended = 14},
              new Student() { Name = "Olexandra", LecturesAttended = 15},
            };

            SemesterEmulation(students);


        }
        public static void AttendLecture(int lecture)
        {
            ++lecture;
        }
       
        
        public static void SemesterEmulation(List<Student> students)
        {
                foreach (var stud in students)
                {
                    if (stud.FavoriteNumber == stud.LecturesAttended)
                    {
                        Console.WriteLine($"{stud.FavoriteNumber} {stud.LecturesAttended}");
                    }
                
                }
        }

    }

   

    class Student
    {
        public string Name { get; set; }

        [JsonIgnore]
        public int FavoriteNumber = GetRandom();


        public int LecturesAttended { get; set; }

        public static int GetRandom()
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 15);
            return randomNumber;
        }
    }
}
/*
3 Write a program which tracks students attendance:
    - You have a Student(Name, FavoriteNumber, LecturesAttended), LecturesAttended will increase by one when you call .AttendLecture()
        - FavoriteNumber should not be serialized, and can't be set, decided randomly(Use Random)
    - You have a function SemesterEmulation which takes a group of students and calls .AttendLecture() on each student
        - BUT if FavoriteNumber is the same as lecture number - student skips the lecture
    - Semester ends in 8 iterations
    - After semester simulation is done, serialize all students in one snapshot.json
    - Next time you run your .exe you should check if such file exists, if so read students and proceed to next semester emulation.

            */