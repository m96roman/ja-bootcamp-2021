using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Pylat_Lecture_9___.Task3
{
    public class Student
    {
        public string Name { get; set; }
        public int FavoriteNumber;
        public int LecturesAttended { get; set; }

        public Student()
        {
            Random random = new Random();
            FavoriteNumber = random.Next(10);
        }

        public void AttendLecture()
        {
            LecturesAttended++;
        }

       public void SemesterEmulation(List<Student> students)
        {
            if (FavoriteNumber != LecturesAttended) {
                for (var i = 0; i<8;i++) {
                    foreach (var student in students)
                    {
                        student.AttendLecture();
                    }
                }
            }
            JsonSerialize(students);
        }

        public void JsonSerialize(List<Student> list)
        {
            
            string fileName = $@"C:\Users\nestor.pylat\ja-bootcamp-2021\Bootcamp\Lecture9\Homework\Pylat Lecture 9!!!\Pylat Lecture 9!!!\snapshot.json";
            string jsonString = JsonSerializer.Serialize(list);
            File.WriteAllText(fileName, jsonString);
        }

        public void JsonDeserialise(string path)
        {
            var studentsFronJson = JsonSerializer.Deserialize<List<Student>>(File.ReadAllText(path));
            SemesterEmulation(studentsFronJson);
        }
    }
}
