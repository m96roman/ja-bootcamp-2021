using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = Student.ReadStudentsFromFile();
            Student.SemesterEmulation(students);
            Student.SerializeStudents(students);
        }
    }
}
