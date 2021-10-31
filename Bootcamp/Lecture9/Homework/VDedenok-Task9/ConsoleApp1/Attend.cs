using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace VDedenok_Task9
{
    class Attend
    {
        public void SemesterEmulation(List<Student> students)
        {
            foreach (var stud in students)
            {
                for (int i = 0; i < 8; i++)
                {
                    stud.FavoriteNumber = GetRandom();

                    if (stud.FavoriteNumber != stud.LecturesAttended)
                    {
                        stud.AttendLecture();
                    }
                }
            }
          
            File.WriteAllText("students.json", JsonSerializer.Serialize(students));
        }

        public static int GetRandom()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
          
            return randomNumber;
        }
    }
}
