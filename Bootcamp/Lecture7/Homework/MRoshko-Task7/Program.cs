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
                .GroupBy(s => s)
                .ToList();

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

            Console.WriteLine($"{String.Join(',', store)}");
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
                .Join(listOfFaculty,
                s => s.FacultyId,
                f => f.FacultyId,
                (s, f) => new { Student = s.FirstName, Faculty = f.Name })
                .ToList();


            Console.WriteLine("Print All students with max grade per Faculty like: {FacultyName,StudentName}\n");

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Faculty}:{item.Student}");
            }

            Console.WriteLine("\nHow many students with the same name?\n");

            var result1 = listOfStudents
<<<<<<< HEAD
                .GroupBy(student => student.FirstName)
                .Select(sstudent => sstudent);
=======
                .Select(s => s)
                .GroupBy(student => student.FirstName)
                .OrderBy(studentName => studentName.Count())
                .Select(sstudent => sstudent).ToList();
>>>>>>> 05892f220c0c9a5d60ac5f4294e21b259b199e1e

            foreach (var item in result1)
            {
                Console.WriteLine($"{item.Key}:{item.Count()}");
            }

            Console.WriteLine("\nHow many students with the same name per faculty?\n");
<<<<<<< HEAD

            var result3 = listOfStudents
                .Join(listOfFaculty,
                    s => s.FacultyId,
                    f => f.FacultyId,
                    (s, f) => new { Student = s, Faculty = f })
                .GroupBy(f => f.Faculty.FacultyId);

            foreach (var item in result3)
            {
                Console.WriteLine($"{item.First().Faculty.Name}");
                foreach (var item2 in item.GroupBy(name => name.Student.FirstName))
                {
                    Console.WriteLine($"{item2.Key}{item2.Count()}");
                }
            }

            Console.WriteLine("\nFind average grade per faculty\n");

            var result4 = listOfStudents
                .Join(listOfFaculty,
                s => s.FacultyId,
                f => f.FacultyId,
                (s, f) => new { Student = s, Faculty = f })
                .GroupBy(f => f.Faculty.FacultyId);

=======

            var result3 = listOfStudents
                .Join(listOfFaculty,
                    s => s.FacultyId,
                    f => f.FacultyId,
                    (s, f) => new { Student = s, Faculty = f })
                .GroupBy(f => f.Faculty.FacultyId);

            foreach (var item in result3)
            {
                Console.WriteLine($"{item.First().Faculty.Name}");
                foreach (var item2 in item.GroupBy(name => name.Student.FirstName))
                {
                    Console.WriteLine($"{item2.Key}{item2.Count()}");
                }
            }

            Console.WriteLine("\nFind average grade per faculty\n");

            var result4 = listOfStudents
                .Join(listOfFaculty,
                s => s.FacultyId,
                f => f.FacultyId,
                (s, f) => new { Student = s, Faculty = f })
                .GroupBy(f => f.Faculty.FacultyId);

>>>>>>> 05892f220c0c9a5d60ac5f4294e21b259b199e1e
            foreach (var item in result4)
            {

                Console.WriteLine($"{item.First().Faculty.Name} {item.Select(s => s.Student.AverageGrade).Average()}");

            }

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
