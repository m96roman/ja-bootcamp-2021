using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    public struct Student
    {
        public int StudentId { get; set; }
        public int FacultyId { get; set; }
        public string FirstName { get; set; }
        public int AverageGrade { get; set; }

        public Student(int studentId, int facultyId, string firstName, int averageGrade)
        {
            StudentId = studentId;
            FacultyId = facultyId;
            FirstName = firstName;
            AverageGrade = averageGrade;
        }
    }
}
