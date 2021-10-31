using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


namespace VDedenok_Task9
{
    class Task3
    {
        public void RunTask3()
        {
            List<Student> students = new List<Student>();
           
            Attend goOneSemester = new Attend();

            if (File.Exists("students.json"))
            {
                students.AddRange(JsonSerializer.Deserialize<List<Student>>(File.ReadAllText("students.json")));

                goOneSemester.SemesterEmulation(students);
                
                Console.WriteLine("File students.json is appended now!");
            }
            else
            {
                students.Add(new Student() { Name = "Vika" });
                students.Add(new Student() { Name = "Nadiya" });
                students.Add(new Student() { Name = "Olya" });
                students.Add(new Student() { Name = "Marina" });
                students.Add(new Student() { Name = "Olexandra" });

                goOneSemester.SemesterEmulation(students);

                Console.WriteLine("File students.json is successfully created first time!");
            }
        }
    }
}
