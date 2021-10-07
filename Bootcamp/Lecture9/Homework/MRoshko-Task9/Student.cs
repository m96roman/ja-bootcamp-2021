using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MRoshko_Task9
{
    public class Student
    {
        public string Name { get; set; }

        [JsonIgnore]
        public int FavoriteNumber { get; private set; }

        public int LecturesAttended { get; set; }

        public Student(string name, int lecturesAttended)
        {
            Name = name;

            FavoriteNumber = new Random().Next(0, 100); 

            LecturesAttended = lecturesAttended;
        }

        public void AttendLecture()
        {
            LecturesAttended++;
        }
    }
}
