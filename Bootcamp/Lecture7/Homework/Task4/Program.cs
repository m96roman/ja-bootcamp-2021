using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Task4
{
    class Program
    {
        public static Random rnd = new Random();

        static void Main(string[] args)
        {
            List<Faculty> facultyList = new List<Faculty>();
            facultyList = InitFaculties(facultyList);
            List<Student> studentList = new List<Student>();
            InitStudents(studentList, facultyList);

            Console.WriteLine("--All students with max grade per Faculty--");
            FindMaxGradePerFaculty(studentList, facultyList);
            Console.WriteLine("--Students with the same name--");
            FindStudentsWithSameName(studentList);
            Console.WriteLine("--Students with the same name per faculty--");
            FindStudentsWithTheSameNamePerFaculty(studentList, facultyList);
            Console.WriteLine("--Average grade per faculty--");
            FindAverageGradePerFaculty(studentList, facultyList);
        }

        static List<Faculty> InitFaculties(List<Faculty> facultyList)
        {
            for (int i = 1; i <= 5; i++)
            {
                facultyList.Add(new Faculty { FacultyId = i, Name = $"Faculty {i}" });
            }

            return facultyList;
        }

        static List<Student> InitStudents(List<Student> studentList, List<Faculty> facultyList)
        {
            for (int i = 1; i <= 10; i++)
            {
                studentList.Add(new Student { StudentId = i, FacultyId = rnd.Next(1, facultyList.Count), FirstName = $"Student Name {i}", AverageGrade = rnd.Next(50, 100) });
                if (i == 5)
                {
                    studentList.Add(new Student { StudentId = 11, FacultyId = rnd.Next(1, facultyList.Count), FirstName = $"Anton", AverageGrade = rnd.Next(50, 100) });
                    studentList.Add(new Student { StudentId = 12, FacultyId = rnd.Next(1, facultyList.Count), FirstName = $"Anton", AverageGrade = rnd.Next(50, 100) });

                    studentList.Add(new Student { StudentId = 13, FacultyId = 2, FirstName = $"Vasyl", AverageGrade = 100 });
                    studentList.Add(new Student { StudentId = 14, FacultyId = 2, FirstName = $"Vasyl", AverageGrade = 100 });
                    studentList.Add(new Student { StudentId = 15, FacultyId = 3, FirstName = $"Anton", AverageGrade = 100 });
                    studentList.Add(new Student { StudentId = 16, FacultyId = 5, FirstName = $"Mykhailo", AverageGrade = 100 });
                }
            }

            return studentList;
        }

        static void FindAverageGradePerFaculty(List<Student> studentList, List<Faculty> facultyList)
        {
            var averageGradePerFaculty = studentList.GroupBy(x => x.FacultyId).
               Join(facultyList, student => student.Key, faculty => faculty.FacultyId,
                   (student, faculty) =>
                        new { FacultyName = faculty.Name, AverageGrade = student.Average(x => x.AverageGrade) }
                ).ToList();

            averageGradePerFaculty.ForEach(x => { Console.WriteLine($"{x.FacultyName} - {x.AverageGrade}"); });
        }

        static void FindStudentsWithTheSameNamePerFaculty(List<Student> studentList, List<Faculty> facultyList)
        {
            var sameNameStudentsFaculty = studentList
                .GroupBy(x => x.FacultyId)
                .Select(faculty => new
                {
                    FacultyId = faculty.Key,
                    AmountSimilar = faculty.GroupBy(x => x.FirstName).Where(x => x.Count() > 1).Sum(x => x.Count())
                })
                .Join(facultyList, amountSimilar => amountSimilar.FacultyId, faculty => faculty.FacultyId,
                   (amountSimilar, faculty) => new
                   {
                       FacultyName = faculty.Name,
                       AmountSimilar = amountSimilar.AmountSimilar
                   }).ToList();

            sameNameStudentsFaculty.ForEach(x => { Console.WriteLine($"{x.FacultyName} - {x.AmountSimilar}"); });
        }

        static void FindStudentsWithSameName(List<Student> studentList)
        {
            //first way
            var frequency = from student in studentList
                            group student by student.FirstName into stud
                            select new { StudentName = stud.Key, IsSimilar = stud.Count() };

            foreach (var item in frequency)
            {
                Console.WriteLine($"StudentName = {item.StudentName}, IsSimilar = {item.IsSimilar}");
            }

            //second way (show amount students with the same name)
            var freq = studentList
                .GroupBy(x => x.FirstName)
                .Where(student => student.Count() > 1)
                .Sum(student => student.Count());
            Console.WriteLine($"Amount students with the same name {freq}");
        }

        static void FindMaxGradePerFaculty(List<Student> studentList, List<Faculty> facultyList)
        {
            var averageGradePerFaculty = studentList
                .GroupBy(x => x.FacultyId)
                .Select(faculty => new
                {
                    Key = faculty.Key,
                    Grades = faculty.GroupBy(x => x.AverageGrade)
                            .OrderByDescending(facul => facul.Key)
                            .FirstOrDefault()
                })
                .Join(facultyList, grades => grades.Key, faculty => faculty.FacultyId,
                     (grades, faculty) => new { FacultyName = faculty.Name, GradesTop = grades.Grades })
                .SelectMany(x => x.GradesTop, (faculty, student) => new
                {
                    faculty.FacultyName,
                    student.FirstName,
                    student.AverageGrade
                }).ToList();

            averageGradePerFaculty.ForEach(x => { Console.WriteLine($"{x.FacultyName} - {x.FirstName} - {x.AverageGrade}"); });
        }
    }
}
