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
            Student student2 = new Student() { StudentId = 2, FacultyId = 1, FirstName = "student1", AverageGrade = 11 };
            Student student3 = new Student() { StudentId = 3, FacultyId = 3, FirstName = "student3", AverageGrade = 12 };
            Student student4 = new Student() { StudentId = 4, FacultyId = 4, FirstName = "student4", AverageGrade = 13 };

            Faculty faculty1 = new Faculty() { FacultyId = 1, Name = "Faculty 1" };
            Faculty faculty2 = new Faculty() { FacultyId = 2, Name = "Faculty 2" };
            Faculty faculty3 = new Faculty() { FacultyId = 3, Name = "Faculty 3" };
            Faculty faculty4 = new Faculty() { FacultyId = 4, Name = "Faculty 4" };

            List<Student> studentList = new List<Student>() { student1, student2, student3, student4 };
            List<Faculty> facultyList = new List<Faculty>() { faculty1, faculty2, faculty3, faculty4 };

            var joining = studentList.Join(
                facultyList,
                student => student.FacultyId,
                faculty => faculty.FacultyId,
                (student, faculty) => new
                {
                    StudentName = student,
                    FacultyName = faculty.Name

                });

            var joiningToListed = joining.ToList();
            joiningToListed.ForEach(v => { Console.WriteLine($"{v.StudentName} - {v.FacultyName}"); });
            Console.WriteLine("\n========================================\n");

            var theSameName = joining.GroupBy(e => e.StudentName).ToDictionary(e => e.Key, e => e.Count()).ToList();
            theSameName.ForEach(v => { Console.WriteLine($"{v.Key}'s count is: {v.Value}"); });
            Console.WriteLine("\n========================================\n");

            var theSameFaculty = joining.GroupBy(e => e.FacultyName).ToDictionary(e => e.Key, e => e.Count()).ToList();
            theSameFaculty.ForEach(v => { Console.WriteLine($"{v.Key}'s count is: {v.Value}"); });
            Console.WriteLine("\n========================================\n");

            var averageGrade = joining.Select(e => e).Average(e => e.StudentName.AverageGrade);
            Console.WriteLine($"Average grade is - {averageGrade}");
            Console.WriteLine("\n========================================\n");
        }
    }
}
