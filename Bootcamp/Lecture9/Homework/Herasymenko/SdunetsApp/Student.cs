using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SdunetsApp
{
    public class Student
    {
        public string Name { get; set; }
        [JsonIgnore]
        private int FavoriteNumber { get; set; } = new Random().Next(1, 8);
        public int LecturesAttended { get; set; }

        public void AttendLecture()
        {
            LecturesAttended++;
        }

        public List<Student> SemesterEmulation(List<Student> students)
        {

            var studentsList = new List<Student>();

            for (int i = 0; i < 8; i++)
            {

                foreach (var student in students)
                {
                    if(student.FavoriteNumber != LecturesAttended)
                    {
                        student.AttendLecture();
                        studentsList.Add(student);
                    }
                }
            }

            return studentsList;
        }

        public void PrepareJson(List<Student> students)
        {
            string currentDir = Directory.GetCurrentDirectory();
            string json = JsonSerializer.Serialize(students);


            if (!File.Exists(@$"{currentDir}\snapshot.json"))
            {
                File.WriteAllText(@$"{currentDir}\snapshot.json", json);
            }
            else
            {
                File.WriteAllText(@$"{currentDir}\snapshot{DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss")}.json", json);
            }
        }
    }
}
