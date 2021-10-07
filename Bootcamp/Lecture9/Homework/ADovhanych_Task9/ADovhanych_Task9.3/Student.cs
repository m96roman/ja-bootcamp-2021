using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADovhanych_Task9._3
{
    class Student
    {
        public string Name { get; set; }

        public int FavoriteNumber { get; set; }

        public int LecturesAttended { get; set; }

        public Student(string name)
        {
            Name = name;
            Random random = new();
            int v = random.Next(0, 10);
            FavoriteNumber = v;
            LecturesAttended = 0;
        }

        public void AttendLecture()
        {
            
        }
    }
}
