using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DIvanyshyn_9.StudentTracker
{
    class Task3
    {
        private static readonly string fileName = "snapshot.json";

        internal static void Execute()
        {

            IEnumerable<Student> students = null;
            students = Deserialize(fileName);

            if (students == null)
            {
                Console.WriteLine("We are using custom students");
                students = new List<Student> {
                    new("Petro"),
                    new("Vasyl"),
                    new("Ivan"),
                    new("Radjeh"),
                    new("Sviatoslav")
                };
            }

            SemesterEmulation(students, 8);

            Serialize(students, fileName);
        }

        /// <summary>
        /// Return deserualized collection of studetns or null
        /// </summary>
        /// <param name="fileName">File name from which students will be loaded</param>
        /// <returns><see cref="IEnumerable{T}"/> or <see cref="null"/></returns>
        private static IEnumerable<Student> Deserialize(string fileName)
        {
            try
            {
                var pathToFile = Path.Combine(Directory.GetCurrentDirectory(), fileName);
                if (File.Exists(pathToFile))
                {
                    return JsonSerializer.Deserialize<IEnumerable<Student>>(File.ReadAllText(pathToFile));
                }
            }
            catch (Exception exe)
            {
                Console.WriteLine(exe);
            }

            return null;
        }

        /// <summary>
        /// Serializes <paramref name="students"/> in file inside 
        /// root directory with name specified in <paramref name="fileName"/>
        /// </summary>
        /// <param name="students">Collection of students</param>
        /// <param name="fileName">File name of file to which students will be saved</param>
        private static void Serialize(IEnumerable<Student> students, string fileName)
        {
            var serializedStr = JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true });
            var pathToFile = Path.Combine(Directory.GetCurrentDirectory(), fileName);

            using var file = File.Create(pathToFile);
            using var writer = new StreamWriter(file);

            writer.Write(serializedStr);
        }

        /// <summary>
        /// takes a group of students and calls .AttendLecture() on each student <paramref name="lecturesNumber"/> times
        ///  BUT if FavoriteNumber is the same as lecture number - student skips the lecture
        /// </summary>
        /// <param name="students">Collection of student</param>
        /// <param name="lecturesNumber">number of lection</param>
        private static void SemesterEmulation(IEnumerable<Student> students, int lecturesNumber)
        {
            for (int lectureIndex = 1; lectureIndex <= lecturesNumber; lectureIndex++)
            {
                foreach (var item in students.Where(s => s.FavouriteNumber != lectureIndex))
                {
                    Console.WriteLine("Lection number " + lectureIndex);

                    item.AttendLecture();

                    Console.WriteLine(new string('-', 20));
                }
            }
        }
    }
}
