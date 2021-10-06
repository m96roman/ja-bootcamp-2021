using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIvanyshyn_7.Task4
{
    public class Task4
    {
        /// <summary>
        /// Given the following data structure:
        ///- Student(StudentId, FacultyId, FirstName, AverageGrade)
        ///- Faculty(FacultyId, Name)
        ///Print All students with max grade per Faculty like: {FacultyName, StudentName
        ///  }
        /// How many students with the same name? how many students with the same name per faculty?
        /// Find average grade per faculty
        /// </summary>
        public static void Execute()
        {
            List<Faculty> faculties = new List<Faculty>
            {
                new(facultyId:1,name:"Math"),
                new(facultyId:2,name:"Foreign languages"),
                new(facultyId:3,name:"Literature"),
                new(facultyId:4,name:"Smth")
            };
            string[] names = new[] { "Ivan", "Petro", "Vasyl", "Mykola", "Teofaniy", "Dandelion" };

            //This guy is unique!
            List<Student> students = new List<Student> { new Student(1, 1, "Someone unique", 99), new Student(2, 1, "Vasyl", 99) };

            //Just test filling
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                var name = names[random.Next(0, names.Length)];
                students.Add(new Student(i + 1, random.Next(1, faculties.Count + 1), name, random.Next(0, 100)));
            }

            Console.WriteLine(string.Join(Environment.NewLine, students.OrderBy(s => s.FacultyId)));
            Console.WriteLine(new string('-', 20));

            //Print All students with max grade per Faculty like: {FacultyName, StudentName}
            Console.WriteLine("Print All students with max grade per Faculty like: {FacultyName, StudentName}");
            Tak1(students, faculties);

            Console.WriteLine(new string('-', 20));
            //How many students with the same name
            Console.WriteLine("How many students with the same name");
            Task2(students);

            Console.WriteLine(new string('-', 20));
            //How many students with the same name per faculty
            Console.WriteLine("How many students with the same name per faculty");
            Task3(students, faculties);

            Console.WriteLine(new string('-', 20));
            //Find average grade per faculty
            Console.WriteLine("Find average grade per faculty");
            TaskFour(students, faculties);

            Console.WriteLine(new string('-', 20));
        }

        private static void Tak1(List<Student> students, List<Faculty> faculties)
        {
            var goodStudents = students
                .GroupBy(s => s.FacultyId)
                //Selects group with bigger key(AverageGrade)
                .Select(group =>
                    new
                    {
                        Key = group.Key,
                        best = group.GroupBy(s => s.AverageGrade)
                                    .OrderByDescending(sgroup => sgroup.Key)
                                    .First()
                    })
                .Join(faculties,
                    besties => besties.Key,
                    facultie => facultie.FacultyId,
                    (besties, fc) =>
                          new
                          {
                              FacultyName = fc.Name,
                              BestOnFaculty = besties.best
                          })
                .SelectMany(p => p.BestOnFaculty,
                    (facultie, student) =>
                    new
                    {
                        facultie.FacultyName,
                        student.FirstName,
                        student.AverageGrade
                    });

            Console.WriteLine(string.Join("\n", goodStudents));
        }

        private static void Task2(List<Student> students)
        {
            var duplicates = students.GroupBy(s => s.FirstName).Where(studs => studs.Count() > 1).Sum(stud => stud.Count());
            Console.WriteLine(duplicates);
        }

        private static void Task3(List<Student> students, List<Faculty> faculties)
        {
            var namesPerFaculty = students.GroupBy(s => s.FacultyId)
                .Select(group =>
                     new
                     {
                         FacultyKey = group.Key,
                         CountOfDuplicates = group.GroupBy(s => s.FirstName).Where(s => s.Count() > 1).Sum(s => s.Count())
                     })
                .Join(faculties, studentsCount => studentsCount.FacultyKey, fc => fc.FacultyId,
                       (studentsCount, fc) =>
                             new
                             {
                                 FacultyName = fc.Name,
                                 CountOfDuplicates = studentsCount.CountOfDuplicates
                             });

            Console.WriteLine(string.Join("\n", namesPerFaculty));
        }

        private static void TaskFour(List<Student> students, List<Faculty> faculties)
        {
            var averages = students
                .GroupBy(s => s.FacultyId)
               .Join(faculties, studentsGroup => studentsGroup.Key, fc => fc.FacultyId,
                   (studentsGroup, fc) =>
                        new { FacultyName = fc.Name, AverageGrade = studentsGroup.Average(s => s.AverageGrade) });

            Console.WriteLine(string.Join("\n", averages));
        }
    }
}
