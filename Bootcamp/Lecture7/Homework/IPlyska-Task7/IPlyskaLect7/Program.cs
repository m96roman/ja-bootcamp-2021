using System;
using System.Collections.Generic;
using System.Linq;

namespace IPlyskaLect7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 5, 6, 7, 8 };

            List<string> str = new List<string> { "dog", "cat", "tar" };

            List<Student> students = new List<Student>()
            {
                new Student{StudentId = 1, FirstName = "Ivan", FacultyId = 1, AverageGrade = 9 },
                new Student{StudentId = 2, FirstName = "Max", FacultyId = 3, AverageGrade = 7.7m },
                new Student{StudentId = 3, FirstName = "Alex", FacultyId = 2, AverageGrade = 5.5m },
                new Student{StudentId = 4, FirstName = "Tom", FacultyId = 1, AverageGrade = 10 },
                new Student{StudentId = 5, FirstName = "John", FacultyId = 3, AverageGrade = 9.9m },
                new Student{StudentId = 6, FirstName = "Olga", FacultyId = 1, AverageGrade = 7},
                new Student{StudentId = 7, FirstName = "Olga", FacultyId = 1, AverageGrade = 7.8m},
                new Student{StudentId = 3, FirstName = "Alex", FacultyId = 2, AverageGrade = 8 },
                new Student{StudentId = 3, FirstName = "Ivan", FacultyId = 1, AverageGrade = 8 },
            };

            List<Faculty> faculties = new List<Faculty>()
            {
                new Faculty{FacultyId = 1, Name = "MathFaculty"},
                new Faculty{FacultyId = 2, Name = "Physic Faculty"},
                new Faculty{FacultyId = 3, Name = "History Faculty"},
            };

            try
            {
                new Task1().FindSquareNumber(array).PrintObjects();

                CountChar("Milkki");

                Console.WriteLine(ConvertSrtArray(str));

                var result = CountStudent(students);
                var result2 = SameNamePerFaculty(students);

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void CountChar(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException("Argument can not be null or an empty", nameof(input));
            }

            var result = input.Select(x => x).GroupBy(y => y);

            Console.WriteLine("The frequency of the characters are:");

            foreach (var item in result)
            {
                Console.WriteLine($"Character {item.Key}: {item.Count()}");
            }
        }

        public static string ConvertSrtArray(IEnumerable<string> container)
        {
            if (container is null || container.Count() == 0)
            {
                throw new ArgumentNullException("Argument can not be null or an empty", nameof(container));
            }
         
            return container.Aggregate((x ,y) => y + "," + x);
        }

        public static void InnerJoin(IEnumerable<Student> students, IEnumerable<Faculty> faculties)
        {
            var result = students.Join
                (
                    faculties,
                    student => student.FacultyId,
                    faculty => faculty.FacultyId,
                    (student, faculty) => new
                    {
                        StudentId = student.StudentId,
                        FirstName = student.FirstName,
                        FacultyName = faculty.Name,
                        AverageGrade = student.AverageGrade,
                        FacultyId = faculty.FacultyId
                    }
                );   
        }

        //public static List<Student> MaxGradePerFaculty(IEnumerable<Student> students)
        //{
        //    var result = students.GroupBy(x => x.FacultyId).Select(y => y.Where(x => x.AverageGrade > x.AverageGrade));
        //}

        public static IEnumerable<Student> SameNamePerFaculty(IEnumerable<Student> students)
        {
            return students.GroupBy(x => x.FacultyId).Select(y => new Student { FacultyId = y.Key, Quantity = y.Select(m => m).Count() - y.Select(x => x.FirstName).Distinct().Count()});
        }

        public static IEnumerable<Student> AverageGradePerFaculty(IEnumerable<Student> students)
        {
            return (IEnumerable<Student>)students.GroupBy(x  => x.FacultyId).Select(y => y.Select(x => new Student {FacultyId = y.Key, AverageGrade = y.Average(x => x.AverageGrade)}));
        }

        public static int CountStudent(IEnumerable<Student> students) 

            => students.Select(x => x.FirstName).Distinct().Count(); 
   
    }
}

