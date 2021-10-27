using System;
using System.Text.Json.Serialization;

namespace YaroslavB_Task9
{
    class Student
    {
        private static Random _rd = new Random();
        private static int _hiLimit = 17; //max value for favorite number

        [JsonInclude]
        public string Name { get; private set; }

        [JsonIgnore]
        public int FavoriteNumber { get; }

        [JsonInclude]
        public int LecturesAttended { get; private set; }

        public Student()
        {
            FavoriteNumber = GetFavoriteNumber();
        }

        public Student(string name)
        {
            Name = name;
            FavoriteNumber = GetFavoriteNumber();
            LecturesAttended = 0;
        }

        public void AttendLecture(int lectureNumber)
        {
            if (lectureNumber == FavoriteNumber)
            {
                return;
            }

            LecturesAttended++;
        }

        private static int GetFavoriteNumber()
        {
            return _rd.Next(1, _hiLimit);
        }

        public override string ToString()
        {
            return $"{Name},\t" +
                $"favorite number: {FavoriteNumber}\t" +
                $"attended lectures: {LecturesAttended}";
        }
    }
}
