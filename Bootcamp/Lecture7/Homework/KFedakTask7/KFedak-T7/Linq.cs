using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedak_T7
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public double AverageGrade { get; set; }
        public int FacultyID { get; set; }
    }

    public class Faculty
    {
        public int FacultyID { get; set; }
        public string FacultyName { get; set; }
    }

    public static class Linq
    {
        private static IReadOnlyCollection<Student> Students { get; } = new List<Student>
    {
        new Student() { StudentID = 1, StudentName = "John", AverageGrade = 4, FacultyID = 1 },
        new Student() { StudentID = 2, StudentName = "John",  AverageGrade = 3, FacultyID = 1 },
        new Student() { StudentID = 3, StudentName = "Bill",  AverageGrade = 5, FacultyID = 2 },
        new Student() { StudentID = 4, StudentName = "Ron" , AverageGrade = 5, FacultyID = 3 },
        new Student() { StudentID = 5, StudentName = "Ron" , AverageGrade = 5, FacultyID = 3 },
        new Student() { StudentID = 6, StudentName = "Oleg" , AverageGrade = 5, FacultyID = 3 }

    };

        private static IReadOnlyCollection<Faculty> Facultys { get; } = new List<Faculty>
    {
        new Faculty(){ FacultyID = 1, FacultyName="Faculty 1"},
        new Faculty(){ FacultyID = 2, FacultyName="Faculty 2"},
        new Faculty(){ FacultyID = 3, FacultyName="Faculty 3"}
    };

        public static void StudentsWithMaxGradePerFaculty()
        {
            var innerJoin = Students.Join(Facultys,
                student => student.FacultyID,
                      standard => standard.FacultyID,
                      (student, standard) => new
                      {
                          StudentName = student.StudentName,
                          FacultyName = standard.FacultyName,
                          FacultyID = standard.FacultyID,
                          AverageGrade = student.AverageGrade
                      });

            var students1 = innerJoin.GroupBy(f => f.FacultyID)
                .Select(s =>
                new
                {
                    max = string.Join(",", s.Where(y => y.AverageGrade == s.Max(mark => mark.AverageGrade)).Select(z => z.AverageGrade)),
                    facultyID = s.Key,
                    FacultyName = s.First(y => y.AverageGrade == s.Max(mark => mark.AverageGrade)).FacultyName,
                    StudentName = string.Join(",", s.Where(y => y.AverageGrade == s.Max(mark => mark.AverageGrade)).Select(z => z.StudentName))

                });

            foreach (var st in students1)
            {
                Console.WriteLine("Student {0} and {1}", st.StudentName, st.FacultyName);
            }
        }

        public static void SameName()
        {
            var students = Students.GroupBy(s => s.StudentName)
                .Select(s => new { count = s.Count(), studentName = s.Key })
                .OrderByDescending(s => s.count)
                .Select(s => new { StudentName = s.studentName, Count = s.count });

            foreach (var st in students)
            {
                Console.WriteLine("Student {0} - count:{1}", st.StudentName, st.Count);
            }
        }

        public static void SameNamePerFaculty()
        {
            var students = Students.GroupBy(s => s.FacultyID)
                .Select(group =>
                new
                {
                    FacultyID = group.Key,
                    Count = group.GroupBy(s => s.StudentName).Where(s => s.Count() > 1).Sum(s => s.Count())
                })
                .Join(Facultys,
                count => count.FacultyID,
                f => f.FacultyID,
                    (count, f) =>
                    new
                    {
                        FacultyName = f.FacultyName,
                        Count = count.Count,
                    });

            foreach (var st in students)
            {
                Console.WriteLine(" {0} - count:{1}", st.FacultyName, st.Count);
            }
        }
        public static void Average()
        {
            var averagesOfStudents = Students.GroupBy(s => s.FacultyID)
                .Join(Facultys,
                s => s.Key,
                f => f.FacultyID,
                (student, faculty) =>
                new
                {
                    FacultyName = faculty.FacultyName,
                    AverageGrade = student.Average(s => s.AverageGrade)
                });

            foreach (var st in averagesOfStudents)
            {
                Console.WriteLine(" {0} - Average:{1}", st.FacultyName, st.AverageGrade);
            }
        }
    }
}
