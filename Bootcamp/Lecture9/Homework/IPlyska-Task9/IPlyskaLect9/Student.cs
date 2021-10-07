using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace IPlyskaLect9
{
    public class Student
    {
        public string Name { get; set; }

        [field: NonSerialized]
        public int FavoriteNumber { get; private set; }

        public int LecturesAttended { get; set; }

        Random random = new Random();

        public Student()
        {
            FavoriteNumber = random.Next(1,20);
        }

        public void AttendLecture()
        {
            if ((LecturesAttended += 1) != FavoriteNumber)
            {
                LecturesAttended++;
            }   
        }

        public static void SemesterEmulation(List<Student> students)
        {
            if (students is null || students.Count == 0)
            {
                throw new ArgumentNullException("Argument can not be null or an empty", nameof(students));
            }

            for (int i = 0; i < 8; i++)
            {
                foreach (var item in students)
                {
                    item.AttendLecture();
                }
            }  
        }

        public static void SerializeStudents(List<Student> students)
        {
            if (students is null || students.Count == 0)
            {
                throw new ArgumentNullException("Argument can not be null or an empty", nameof(students));
            }

            File.WriteAllText("snapshot.json", JsonSerializer.Serialize(students));
        }

        public static List<Student> DeSerialize()
        {
            if (!File.Exists("snapshot.json"))
            {
                return new List<Student>();
            }

           return JsonSerializer.Deserialize<List<Student>>(File.ReadAllText("snapshot.json"));  
        }
    }
}
