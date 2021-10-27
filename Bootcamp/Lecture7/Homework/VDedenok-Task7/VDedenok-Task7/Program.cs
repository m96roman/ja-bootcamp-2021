using System;
using System.Linq;
using System.Collections.Generic;

namespace VDedenok_Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------Task1------------");

            int[] nums = new int[] { 1, 2, 3, 4, 5 };

            var numsToSquare = from n in nums
                               select new { num = n, numSquared = n * n };

            foreach (var item in numsToSquare)
            {
                Console.WriteLine($"Number = { item.num}, SqrNo = {item.numSquared}.");
            }


            Console.WriteLine("-----------Task2------------");

            string str = "example";
            var result = str.ToCharArray();
            var stringCount = from character in result
                              group character by character into y
                              select new { Char = y.Key, Count = y.Count() };

            foreach (var item in stringCount)
            {
                Console.WriteLine($"Character {item.Char} : {item.Count} time(s).");
            }

            
            Console.WriteLine("-----------Task3------------");
            Console.WriteLine("Enter some number of words and then type it:");

            int numberOfWords = int.Parse(Console.ReadLine());

            List<string> Words = new();

            for (var i = 0; i < numberOfWords; i++)
            {

                string word = Console.ReadLine();
                Words.Add(word);
            }

            string joinedString = string.Join(", ", Words);

            Console.WriteLine(joinedString);
            
           
            Console.WriteLine("-----------Task4------------");

            List<Student> studentsList = new List<Student>
            {
                new Student() {StudentId = 1, FacultyId =3, FirstName = "Anna", AverageGrade = 7},
                new Student() {StudentId = 2, FacultyId =3, FirstName = "Fedir", AverageGrade = 9},
                new Student() {StudentId = 3, FacultyId =4, FirstName = "Oleh", AverageGrade = 10},
                new Student() {StudentId = 4, FacultyId =4, FirstName = "Mikola", AverageGrade = 7},
                new Student() {StudentId = 5, FacultyId =10, FirstName = "Vitya", AverageGrade = 1},
                new Student() {StudentId = 6, FacultyId =10, FirstName = "Vitya", AverageGrade = 4},
                new Student() {StudentId = 7, FacultyId =7, FirstName = "Vitya", AverageGrade = 5},
                new Student() {StudentId = 8, FacultyId =8, FirstName = "Mikola", AverageGrade = 4}
            };

            List<Faculty> faculties = new List<Faculty>
            {
                new Faculty() {FacultyId = 4, Name = "Geography"},
                new Faculty() {FacultyId = 3, Name = "Mathematics"},
                new Faculty() {FacultyId = 8, Name = "Philology"},
                new Faculty() {FacultyId = 7, Name = "Arts"},
                new Faculty() {FacultyId = 10, Name = "History"},

            };

            var joined = studentsList.Join(
             faculties,
             st => st.FacultyId,
             fl => fl.FacultyId,
             (st, fl) => new {
                 StudentName = st.FirstName,
                 FacultyId = fl.FacultyId,
                 FacultyName = fl.Name,
                 AverGrade = st.AverageGrade,
                 StudentId = st.StudentId
             }
             ).ToList();

           
            Console.WriteLine("----------------------------");
            Console.WriteLine("------Print All students with max grade per Faculty like: { FacultyName, StudentName}.");

            var studWithMaxGrade = joined.OrderByDescending(st => st.AverGrade)
                             .GroupBy(f => f.FacultyId)
                             .Select(st => st.First());

            foreach (var i in studWithMaxGrade)
            {
                Console.WriteLine($"For {i.FacultyName} the highest grade has {i.StudentName}.");
            }


            Console.WriteLine("----------------------------");
            Console.WriteLine("------How many students with the same name?");

            var groupedByName = from st in studentsList
                                group st by st.FirstName into gr
                                select new { Name = gr.Key, Count = gr.Count().ToString() };

            foreach (var item in groupedByName)
            {
                Console.WriteLine($"Name {item.Name} appears {item.Count} times.");
            }


            Console.WriteLine("----------------------------");
            Console.WriteLine("------Find average grade per faculty.");

            var maxGradePerFaculty = joined.GroupBy(
                f => f.FacultyName,
                f => f.AverGrade,
                (name, grade) => new
                {
                    FacultyName = name,
                    AvrGrade = grade.Average()
                }
                );

            foreach (var item in maxGradePerFaculty)
            {
                Console.WriteLine($"Faculty {item.FacultyName} has average grade {item.AvrGrade}.");
            }
        }
    }
}





