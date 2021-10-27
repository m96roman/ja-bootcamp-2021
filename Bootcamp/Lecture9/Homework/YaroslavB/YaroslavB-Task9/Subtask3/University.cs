using System;
using System.Collections.Generic;
using System.Threading;

namespace YaroslavB_Task9
{
    class University
    {
        private static int _semesterLength = 8;

        private static int _lectureDuration = 400;

        private static List<Student> _students;

        public static event EventHandler<List<Student>> OnSemesterEnds;

        public static void SemesterEmulation(List<Student> students)
        {
            _students = students;
            Console.WriteLine($"\nNew semester is started, invited - {students.Count} students.");

            for (int lecture = 1; lecture <= _semesterLength; lecture++)
            {
                Console.WriteLine($"Lecture {lecture} ...");

                foreach (var student in students)
                {
                    student.AttendLecture(lecture);
                }

                Thread.Sleep(_lectureDuration);
            }

            Console.WriteLine($"\nSemester is finished, {_semesterLength} lectures were held");
            OnSemesterEnds?.Invoke(null, students);
        }

        public static void ShowAttendingResults()
        {
            Console.WriteLine("\nAttending results:");
            foreach (var student in _students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
