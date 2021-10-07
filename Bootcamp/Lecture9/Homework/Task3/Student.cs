using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Task3
{
    public class Student
    {
        public string Name { get; set; }
        [field: NonSerialized]
        private int FavoriteNumber { get; set; }
        public int LecturesAttended { get; set; }

        private static Random rnd = new Random();

        public Student()
        {
            FavoriteNumber = rnd.Next(1, 16);
        }

        public Student(string name, int lectures)
        {
            Name = name;
            FavoriteNumber = rnd.Next(1, 16);
            LecturesAttended = lectures;
        }

        public void AttendLecture()
        {
            if((LecturesAttended + 1) != FavoriteNumber)
            {
                LecturesAttended++;
            }
        }

        public static void SemesterEmulation(List<Student> students)
        {
            for (int i = 0; i < 8; i++)
            {
                foreach (var stud in students)
                {
                    stud.AttendLecture();
                }
            }
        }

        public static void SerializeStudents(List<Student> students)
        {
            var studentJson = JsonSerializer.Serialize(students, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                WriteIndented = true
            });

            File.WriteAllText(@"C:\Projects\Lecture 9 .Net\Task3\student.json", studentJson);
        }

        public static void ReadStudentsFromFile()
        {
            if(File.Exists(@"C:\Projects\Lecture 9 .Net\Task3\student.json"))
            {
                var readJsonFromFile = File.ReadAllText(@"C:\Projects\Lecture 9 .Net\Task3\student.json");
                var deserialixedStudents = JsonSerializer.Deserialize<List<Student>>(readJsonFromFile);

                Console.WriteLine("Students: ");
                foreach(var item in deserialixedStudents)
                {
                    Console.WriteLine($"Name -> {item.Name}, LecturesAttended -> {item.LecturesAttended}");
                }
            }
        }
    }
}
