using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Task_1
{
    public class Student
    {
        public int StudentId;
        public int FacultyId;
        public string FirstName;
        public int AverageGrade;

        internal static object Join()
        {
            throw new NotImplementedException();
        }
    }

    public class Faculty
    {
        public int FacultyId;
        public string Name;
    }

    class Task4
    {
        public static void JoinStudentAndFaculty()
        {
            Student student1 = new Student() { StudentId = 1, FacultyId = 1, FirstName = "student1", AverageGrade = 10 };
            Student student2 = new Student() { StudentId = 2, FacultyId = 6, FirstName = "student1", AverageGrade = 11 };
            Student student3 = new Student() { StudentId = 3, FacultyId = 3, FirstName = "student3", AverageGrade = 12 };
            Student student4 = new Student() { StudentId = 4, FacultyId = 4, FirstName = "student4", AverageGrade = 13 };
            Student student5 = new Student() { StudentId = 5, FacultyId = 4, FirstName = "student5", AverageGrade = 30 };

            Faculty faculty1 = new Faculty() { FacultyId = 1, Name = "Faculty 1" };
            Faculty faculty2 = new Faculty() { FacultyId = 6, Name = "Faculty 2" };
            Faculty faculty3 = new Faculty() { FacultyId = 3, Name = "Faculty 3" };
            Faculty faculty4 = new Faculty() { FacultyId = 4, Name = "Faculty 4" };

            List<Student> studentList = new List<Student>() { student1, student2, student3, student4, student5 };
            List<Faculty> facultyList = new List<Faculty>() { faculty1, faculty2, faculty3, faculty4 };

            var joining = studentList.Join(
                facultyList,
                student => student.FacultyId,
                faculty => faculty.FacultyId,
                (student, faculty) => new
                {
                    StudentName = student,
                    FacultyName = faculty.Name

                }).ToList();

            var joiningToListed = joining.GroupBy(e =>e.FacultyName)
                .Select(e => new { faculty = e.Key, MaxGrades = e
                .GroupBy(a => a.StudentName.AverageGrade)
                .OrderByDescending(y => y.Key).First() })
                .SelectMany(e => e.MaxGrades, (faculty, student)=>
                new { FacultyName = faculty.faculty, student = student.StudentName.FirstName })
                .ToList();

            joiningToListed.ForEach(v => { Console.WriteLine($"{v.FacultyName} - {v.student}"); }); 
            Console.WriteLine("\n========================================\n");

            var theSameName = joining.GroupBy(e => e.StudentName.FirstName)
                .ToDictionary(e => e.Key, e => e
                .Count()).ToList();

            theSameName.ForEach(v => { Console.WriteLine($"{v.Key}'s count is: {v.Value}"); });
            Console.WriteLine("\n========================================\n");

            var theSameFaculty = joining.GroupBy(e => e.FacultyName)
                .ToDictionary(e => e.Key, e => e
                .Count()).ToList();

            theSameFaculty.ForEach(v => { Console.WriteLine($"{v.Key}'s count is: {v.Value}"); });
            Console.WriteLine("\n========================================\n");

            var averageGrade = joining.GroupBy(joined => joined.FacultyName)
                .Select(group => new { Faculty = group.Key, Avg = group
                .Average(student => student.StudentName.AverageGrade) }).ToList();

            averageGrade.ForEach(e => { Console.WriteLine($"{e.Faculty} average grade = {e.Avg}"); });
            Console.WriteLine("\n========================================\n");
        }
    }
}
