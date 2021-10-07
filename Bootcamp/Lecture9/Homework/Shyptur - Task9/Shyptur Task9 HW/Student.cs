using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Shyptur_Task9_HW
{
    class Student
    {
        public string Name { get; set; }

        [JsonIgnore]
        public int FavoriteNumber { get; set; }

        public int LecturesAttended { get; set; }

        public Student(string name)
        {
            Random rnd = new Random();
            Name = name;
            FavoriteNumber = rnd.Next(0, 12);
            LecturesAttended = 0;
        }


        public void AttendLecture(int numberOfLecture)
        {

            if (numberOfLecture != FavoriteNumber)
            {
                LecturesAttended += 1;
            }
        }
    }
}
