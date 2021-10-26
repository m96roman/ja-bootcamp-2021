using System;
using System.Text.Json.Serialization;

namespace ADovhanych_Task9._3
{
    class Student
    {
        public string Name { get; set; }

        [JsonIgnore]
        public int FavoriteNumber { get; set; }

        public int LecturesAttended { get; set; }

        [JsonConstructor]
        public Student(string name)
        {
            Name = name;
            FavoriteNumber = new Random().Next(0, 20);
            LecturesAttended = 0;
        }

        public void AttendLecture(int lectureNumber)
        {
            if (FavoriteNumber != lectureNumber)
            {
                LecturesAttended++;
            }
        }
    }
}
