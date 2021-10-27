using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Pylat_Lecture_9___.Task3;


namespace Pylat_Lecture_9_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var pathTask1 = @"C:\Users\nestor.pylat\ja-bootcamp-2021\Bootcamp\Lecture9\Homework\Pylat Lecture 9!!!\Pylat Lecture 9!!!\Text.txt";
            string pathTask3 = $@"C:\Users\nestor.pylat\ja-bootcamp-2021\Bootcamp\Lecture9\Homework\Pylat Lecture 9!!!\Pylat Lecture 9!!!\snapshot.json";

            //   Task 1 //////////////
            /* LineCounter lineCounter = new LineCounter();
             lineCounter.CreateFileTxt();
             lineCounter.CountLines(pathTask1);*/


            // Task 2 //////////////////////

            // Task2.StartProgram();

            // Task3  ////////////////////

            List<Student> students = new List<Student>();
            Student student = new Student();

            if (File.Exists(pathTask3))
            {
                student.JsonDeserialise(pathTask3);
            }
            else
            {
                Student student1 = new Student() { Name = "r", LecturesAttended = 8 };
                Student student2 = new Student() { Name = "t", LecturesAttended = 1 };
                Student student3 = new Student() { Name = "yu", LecturesAttended = 2 };
                Student student4 = new Student() { Name = "i", LecturesAttended = 3 };
                Student student5 = new Student() { Name = "o", LecturesAttended = 4 };

                students.Add(student1);
                students.Add(student2);
                students.Add(student3);
                students.Add(student4);
                students.Add(student5);

                student.SemesterEmulation(students);
            }
            // Task4 /////////////////////////



        }
    }
}
