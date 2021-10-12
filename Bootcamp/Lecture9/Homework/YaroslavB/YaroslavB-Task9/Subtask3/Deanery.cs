using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace YaroslavB_Task9
{
    class Deanery
    {
        private static string _jsonFile = Path.Combine(Directory.GetCurrentDirectory(), "students.json");


        public static List<Student> GetStudents()
        {
            University.OnSemesterEnds += Serialize;

            List<Student> students;

            students = DeSerialize(out bool status);

            if (!status)
            {
                students = GetNewStudents();
            }

            return students;
        }

        private static List<Student> DeSerialize(out bool status)
        {
            List<Student> deserializedStudents = null;
            status = false;

            if (!File.Exists(_jsonFile))
            {
                return deserializedStudents;
            }

            var jsonData = File.ReadAllText(_jsonFile);

            try
            {
                deserializedStudents = JsonSerializer.Deserialize<List<Student>>(jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return deserializedStudents;
            }

            if (deserializedStudents.Count == 0)
            {
                return deserializedStudents;
            }

            status = true;
            return deserializedStudents;
        }

        private static void Serialize(object sender, List<Student> students)
        {
            File.WriteAllText(_jsonFile, JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true }));
        }

        private static List<Student> GetNewStudents()
        {
            var students = new List<Student>()
            {
                new Student("Jack"),
                new Student("Marry"),
                new Student("Lisa"),
                new Student("Adam"),
                new Student("Henry"),
                new Student("Maria"),
                new Student("Anna"),
                new Student("Gary"),
                new Student("Brian"),
                new Student("Ashley")
            };

            return students;
        }
    }
}
