using System;
using System.Collections.Generic;
using System.Linq;

namespace ADovhanych_Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new[] { 1, 2, 3, 4 };
            var result = number.Select(num => (Number: num, Sqr: num * num));

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("____________Task2____________"); ;

            Console.Write("\nInput the string : ");
            string someStirng = Console.ReadLine();
            IEnumerable<IGrouping<char, char>> output = someStirng.GroupBy(str => str);

            foreach (var item in output)
            {
                Console.WriteLine($"Character : {item.Key}, {item.Count()} times");
            }

            Console.WriteLine("___________Task3_____________");

            Console.Write("\nInput number of strings to store in array ");
            int n = int.Parse(Console.ReadLine());
            string[] strArr = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element[{i}] : ");
                strArr[i] = Console.ReadLine();
            }

            var outputString = strArr.Aggregate((x, y) => x + ", " + y);
            Console.WriteLine($"Here is the string below created with elements of the above array : \n{outputString}");

            Console.WriteLine("_________Task4___________\n");

            List<Student> studentList = new()
            {
                new Student() { StudentID = 1, FirstName = "John", AverageGrade = 78, FacultyId = 1 },
                new Student() { StudentID = 2, FirstName = "Steve", AverageGrade = 61, FacultyId = 2 },
                new Student() { StudentID = 3, FirstName = "Bill", AverageGrade = 81, FacultyId = 3 },
                new Student() { StudentID = 4, FirstName = "Ram" , AverageGrade = 90, FacultyId = 3 },
                new Student() { StudentID = 5, FirstName = "Ron" , AverageGrade = 81, FacultyId = 2 },
                new Student() { StudentID = 5, FirstName = "Ron" , AverageGrade = 83, FacultyId = 1 },
                new Student() { StudentID = 7, FirstName = "Chris", AverageGrade = 95, FacultyId = 1 },
                new Student() { StudentID = 7, FirstName = "Chris", AverageGrade = 70, FacultyId = 1 },
                new Student() { StudentID = 9, FirstName = "Chris", AverageGrade = 79, FacultyId = 2 },
            };

            List<Faculty> facultyList = new()
            {
                new Faculty() { FacultyId = 1, Name = "Math" },
                new Faculty() { FacultyId = 2, Name = "Art" },
                new Faculty() { FacultyId = 3, Name = "Philosophy" },
            };

            var maxGrade = studentList
                .OrderByDescending(avg => avg.AverageGrade)
                .GroupBy(fid => fid.FacultyId)
                .Select(stud => stud.First())
                .ToList()
                .Join(facultyList, 
                studentList => studentList.FacultyId, 
                facultyList => facultyList.FacultyId, 
                (studentList, facultyList) => (facultyList.Name, StudentName: studentList.FirstName, studentList.AverageGrade));

            var sameName = studentList.Join(facultyList,
                studentList => studentList.FacultyId,
                facultyList => facultyList.FacultyId,
                (studentList, facultyList) => (Student: studentList, Faculty: facultyList))
                .GroupBy(fName => fName.Faculty.Name);

            foreach(var item in sameName)
{
                Console.WriteLine(item.Key);
                foreach (var unit in item.GroupBy(name => name.Student.FirstName))
                {
                    Console.WriteLine(unit.Key + " - " + unit.Count());
                }
            }

            var findAvg = studentList
                .GroupBy(fid => fid.FacultyId)
                .Select(id => new
                {
                    FacultyId = id.Key,
                    Average = id
                .Average(avg => avg.AverageGrade)
                });

            foreach (var item in findAvg)
            {
                Console.WriteLine(item);
            }
        }
    }
}
