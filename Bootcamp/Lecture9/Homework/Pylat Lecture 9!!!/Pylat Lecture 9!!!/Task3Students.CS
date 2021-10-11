/*using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Pylat_Lecture_9_Task_1
{
    public class Task3Students
    {
        public int FavoriteNumber { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public int LecturesAttended { get; set; }

        public Task3Students()
        {
            FavoriteNumber = new Random().Next(1, 20);
        }

        public void AttendedLecture()
        {
            LecturesAttended++;
        }
    }

    public class DoTask3
    {
        public static void SemesterEmulation(List<Task3Students> students)
        {
            File.WriteAllText("snapshot.txt", JsonSerializer.Serialize(students));
        }

        static public void SimulateSemestr()
        {
            var students = new List<Task3Students>();

            if (File.Exists("snapshot.txt"))
            {
                var readText = File.ReadAllText("snapshot.txt");
                students.AddRange(JsonSerializer.Deserialize<List<Task3Students>>(readText));
            }
            else
            {
                students.AddRange(new[]
                {
                    new Task3Students
                    {
                        Name = "Nestor",
                        LecturesAttended = 9
                    },
                    new Task3Students
                    {
                        Name = "Dmytro",
                        LecturesAttended = 7
                    },
                     new Task3Students
                    {
                        Name = "Vasyl",
                        LecturesAttended = 7
                    },
                    new Task3Students
                    {
                        Name = "Kateryna",
                        LecturesAttended = 10
                    }
                });
            }
            Semester(students);
            {
                File.WriteAllText("snapshot.txt", JsonSerializer.Serialize(students));
            }
        }

        public static void Semester(IEnumerable<Task3Students> students)
        {
            for (int i = 0; i < 8; i++)
            {
                foreach (var item in students)
                {
                    item.AttendedLecture();
                }
            }
        }
    }
}

*/