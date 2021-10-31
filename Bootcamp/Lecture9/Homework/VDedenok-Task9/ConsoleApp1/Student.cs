using System.Text.Json.Serialization;

namespace VDedenok_Task9
{
    class Student
    {
        public string Name { get; set; }

        [JsonIgnore]
        public int FavoriteNumber { get; set; }

        public int LecturesAttended { get; set; }

        public void AttendLecture()
        {
            ++this.LecturesAttended;
        }
    }
}
