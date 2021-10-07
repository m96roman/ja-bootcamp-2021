using System;
using System.Text.Json.Serialization;

namespace DIvanyshyn_9.StudentTracker
{
    class Student
    {
        public string Name { get; private set; }

        [JsonIgnore]
        public int FavouriteNumber { get; private set; }

        public int LecturesAttend { get; private set; }

        [JsonConstructor]
        public Student(string name, int lecturesAttend)
        {
            Name = name;
            LecturesAttend = lecturesAttend;
            FavouriteNumber = new Random().Next(1, 8);
        }


        public void AttendLecture()
        {
            Console.WriteLine(new string('=', 20));

            Console.WriteLine($"Student {Name} with favourite number {FavouriteNumber} attend lection one more time");
            Console.WriteLine($"Total attendance {LecturesAttend}");

            Console.WriteLine(new string('=', 20));

            LecturesAttend++;
        }
    }
}
