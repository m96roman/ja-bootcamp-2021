using System;
using System.Collections.Generic;

namespace SdunetsApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student();

            List<Student> students = new List<Student>
            {
                new Student { Name = "Ignat", LecturesAttended = 2},
                new Student { Name = "Gavrulo", LecturesAttended = 7},
                new Student { Name = "Inokentiy", LecturesAttended = 4},
                new Student { Name = "Zunoviy", LecturesAttended = 5},
                new Student { Name = "Sebastian", LecturesAttended = 3},
                new Student { Name = "Barchi", LecturesAttended = 8},
            };

           var result = student.SemesterEmulation(students);
            student.PrepareJson(result);
        }        
    }
}
