using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student("Vasyl", 3),
                new Student("Taras", 0),
                new Student("Pavlo", 10),
                new Student("Andriy", 7),
                new Student("Dariya", 13),
                new Student("Olena", 4),
                new Student("Anna", 15),
                new Student("Olaksandra", 9),
                new Student("Marta", 3),
                new Student("Alina", 11)
            };

            Student.ReadStudentsFromFile();
            Student.SemesterEmulation(students);
            Student.SerializeStudents(students);
        }
    }
}
