using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace MRoshko_Task7
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //Task1();

            //Task2();

            //Task3();

            Task4();
        }

        public static void Task1()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (var numb in numbers)
            {
                Console.WriteLine($" Number = {numb},SqrNo = { Math.Pow(numb, 2)} ");
            }

        }

        public static void Task2()
        {

            var inputData = Console.ReadLine();

            var result = inputData
                .Select(s => s)
                .GroupBy(s => s)
                .OrderBy(s => s.Count())
                .Select(s => s).ToList();

            foreach (var item in result)
            {
                Console.WriteLine($"Character {item.Key}: {item.Count()} times");
            }

        }

        public static void Task3()
        {
            string[] store = new string[3];

            for (var i = 0; i < 3; i++)
            {
                store[i] = Console.ReadLine();
            }

            Console.WriteLine($"{String.Join(',', store.Select(s => s))}");
        }

        public static void Task4()
        {
            var listOfStudents = new List<Student>{
                new Student
                {
                    StudentId = 1,
                    FacultyId = 1,
                    FirstName = "Martin",
                    AverageGrade = 4.9
                },
                 new Student
                {
                    StudentId = 2,
                    FacultyId = 1,
                    FirstName = "Vasya",
                    AverageGrade = 4.2
                },
                  new Student
                {
                    StudentId = 3,
                    FacultyId = 2,
                    FirstName = "Martin",
                    AverageGrade = 2.7
                },
                   new Student
                {
                    StudentId = 4,
                    FacultyId = 1,
                    FirstName = "Max",
                    AverageGrade = 4.7
                },
                    new Student
                {
                    StudentId = 5,
                    FacultyId = 2,
                    FirstName = "John",
                    AverageGrade = 5.0
                },
            };
            var listOfFaculty = new List<Faculty>
            {
                new Faculty
                {
                    FacultyId =1,
                    Name = "Electronic and Engineering",
                },
                new Faculty
                {
                    FacultyId =2,
                    Name = "Mathematical",
                },
            };

            var result = listOfStudents
                .OrderByDescending(s => s.AverageGrade)
                .GroupBy(s => s.FacultyId)
                .Select(s => s.First())
                .ToList();

            var outResult = (from t in result
                             join x in listOfFaculty
                             on t.FacultyId equals x.FacultyId
                             select new
                             {
                                 FacultyName = x.Name,

                                 StudentName = t.FirstName,
                             });

            Console.WriteLine("Print All students with max grade per Faculty like: {FacultyName,StudentName}\n");

            foreach (var item in outResult)
            {
                Console.WriteLine($"{item.FacultyName}:{item.StudentName}");
            }

            Console.WriteLine("\nHow many students with the same name?\n");

            var result1 = listOfStudents
                .Select(s => s)
                .GroupBy(s => s.FirstName)
                .OrderBy(s => s.Count())
                .Select(s => s).ToList();

            foreach (var item in result1)
            {
                Console.WriteLine($"{item.Key}:{item.Count()}");
            }

            //Console.WriteLine("\nHow many students with the same name per faculty?\n");

            // Console.WriteLine("\nFind average grade per faculty\n");       

        }

    }

    public struct Student
    {
        public int StudentId { get; set; }

        public int FacultyId { get; set; }

        public String FirstName { get; set; }

        public double AverageGrade { get; set; }

    }

    public struct Faculty
    {
        public int FacultyId { get; set; }

        public string Name { get; set; }
    }
}
