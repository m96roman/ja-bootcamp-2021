using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Task4
    {
        public void task4()
        {
            List<Student> Students = new List<Student>() {
                new Student() { StudentID = 1, FirstName = "John", FacultyId = 13, AverageGrade = 3 } ,
                new Student() { StudentID = 2, FirstName = "Moin",  FacultyId = 21, AverageGrade = 2.1 } ,
                new Student() { StudentID = 3, FirstName = "Bill",  FacultyId = 15, AverageGrade = 4.7 } ,
                new Student() { StudentID = 4, FirstName = "Ram" , FacultyId = 15, AverageGrade = 3.5 } ,
                new Student() { StudentID = 5, FirstName = "Ram" , FacultyId = 15, AverageGrade = 3 }
            };
            List<Faculty> faculties = new List<Faculty>()
            {
                new Faculty(){FacultyId=13,Name="Math"},
                new Faculty(){FacultyId=21,Name="Math1"},
                new Faculty(){FacultyId=15,Name="Math2"},
                new Faculty(){FacultyId=14,Name="Math3"},

            };

            Console.WriteLine("===================Print All students with max grade per Faculty like: {FacultyName, StudentName}");
            var MaxGradePerFaculty = Students
                 .OrderByDescending(avg => avg.AverageGrade)
                 .GroupBy(str => str.FacultyId)
                 .Select(s => s.First())
                 .ToList()
                 .Join(faculties, 
                    Students => Students.FacultyId, 
                    faculties => faculties.FacultyId, 
                    (Students, faculties) => new { facName = faculties.Name, StudentName = Students.FirstName, AverageGrade = Students.AverageGrade });

            foreach (var item in MaxGradePerFaculty)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("===============How many students with the same name?");
            var solution = Students.GroupBy(str => str.FirstName);
            foreach (var item in solution)
            {
                Console.WriteLine($" {item.Key}: {item.Count()} ");
            }

            Console.WriteLine("===============how many students with the same name per faculty??");
            var group = Students.
                Join(faculties,
                    Students => Students.FacultyId,
                    faculties => faculties.FacultyId,
                    (Students, faculties) => new { student=Students,faculty=faculties }).GroupBy(fc=>fc.faculty.Name);
            
            foreach (var item in group)
            {
                Console.WriteLine(item.Key);
                foreach (var item1 in item.GroupBy(nm => nm.student.FirstName))
                {
                    Console.WriteLine(item1.Key + " - " + item1.Count());
                }                        
            }

            Console.WriteLine("==============Find average grade per faculty");
            var averageperfac = Students.GroupBy(st => st.FacultyId).Select(f => new { FacultyId = f.Key, Average = f.Average(s => s.AverageGrade) });
           
            foreach (var item in averageperfac)
            {
                Console.WriteLine(item);
            }
        }
        public class Student
        {
            public int StudentID { get; set; }
            public int FacultyId { get; set; }
            public string FirstName { get; set; }
            public Double AverageGrade { get; set; }
        }
        public class Faculty
        {
            public int FacultyId { get; set; }
            public string Name { get; set; }
        }
    }
}
