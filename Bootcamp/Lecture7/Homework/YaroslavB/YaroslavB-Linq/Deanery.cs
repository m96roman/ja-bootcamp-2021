using System;
using System.Collections.Generic;

namespace YaroslavB_Linq
{
    class Deanery
    {
        private static Random rd = new Random();

        public static List<Student> GetStudents()
        {
            var students = new List<Student>
            {
                new Student(10, 203, "Jack", GetGrade()),
                new Student(12, 202, "Marry", GetGrade()),
                new Student(14, 201, "Lisa", GetGrade()),
                new Student(16, 202, "Adam", GetGrade()),
                new Student(18, 203, "Henry", GetGrade()),
                new Student(20, 201, "Maria", GetGrade()),
                new Student(22, 203, "Anna", GetGrade()),
                new Student(24, 202, "Gary", GetGrade()),
                new Student(26, 204, "Brian", GetGrade()),
                new Student(28, 202, "Carol", GetGrade()),
                new Student(30, 204, "Ashley", GetGrade()),
                new Student(32, 201, "Mark", GetGrade()),
                new Student(34, 204, "Kevin", GetGrade()),
                new Student(36, 203, "Amy", GetGrade()),
                new Student(38, 204, "Amanda", GetGrade()),
                new Student(40, 201, "Nicole", GetGrade()),
            };

            return students;
        }

        public static List<Faculty> GetFaculties()
        {
            var faculties = new List<Faculty>
            {
                new Faculty(201, "History"),
                new Faculty(202, "Mathematic"),
                new Faculty(203, "Engineering"),
                new Faculty(204, "Medical"),
            };

            return faculties;
        }

        private static double GetGrade(int minGrade = 1, int maxGrade = 5, int round = 1)
        {
            return rd.Next(minGrade, maxGrade) + Math.Round(rd.NextDouble(), round);
        }
    }
}
