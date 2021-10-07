using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ADovhanych_Task9._3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentsList = new();
            
            if (File.Exists("students.json"))
            {
                var readFile = File.ReadAllText("students.json");
                studentsList.AddRange(JsonSerializer.Deserialize<List<Student>>(readFile));
                SemesterEmulation(studentsList);
            }
            else
            {
                studentsList.AddRange(new[]
                {
                    new Student("John"),
                    new Student("Olivia"),
                    new Student("Jack"),
                    new Student("Jen"),
                    new Student("Nick"),
                });

                SemesterEmulation(studentsList);
            }
        }

        public static void SemesterEmulation(List<Student> students)
        {
            for (int iterations = 0; iterations < 8; iterations++)
            {
                foreach (var student in students)
                {
                    student.AttendLecture(iterations);
                }
            }

            File.WriteAllText("students.json", JsonSerializer.Serialize(students));
        } 
    }
}
