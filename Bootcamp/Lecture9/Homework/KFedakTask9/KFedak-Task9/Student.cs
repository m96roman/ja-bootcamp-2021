using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KFedak_Task9
{
    public class Student
    {
        public string Name { get; set; }

        [JsonIgnore]
        public int FavoriteNumber { get; private set; }

        public int LecturesAttended { get; set; }

        public Student()
        {
            FavoriteNumber = new Random().Next(1, 10);
        }

        public void AttendedLecture()
        {

            if (this.FavoriteNumber == this.LecturesAttended)
            {
                LecturesAttended--;
            }
            else
            {
                this.LecturesAttended++;
            }
        }
    }
}
