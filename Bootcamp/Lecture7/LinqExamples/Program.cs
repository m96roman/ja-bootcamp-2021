using LinqExamples.LinqExpressions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        => (StudentID, StudentName, Age).ToString();
    }

    static class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>{
                new Student() { StudentID = 1, StudentName = "John", Age = 18 },
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 },
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 21 },
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 },
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 28 },
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 24 },
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
                new Student() { StudentID = 6, StudentName = "Chris",  Age = 19 },
                new Student() { StudentID = 7, StudentName = "Rob",Age = 19  },
            };

            var students = new List<Student>();

            foreach (Student std in studentList)
            {
                if (std.Age > 12 && std.Age < 20)
                {
                    students.Add(std);
                }
            }

            PrintStudent(students);
            Console.WriteLine("========USing LINQ===========");

            PrintStudent(studentList.Where(std => std.Age > 12 && std.Age < 20));

            var queryExpression = from std in studentList
                                  let ageIn20 = std.Age + 20
                                  where std.Age > 12 && ageIn20 < 40
                                  select std;
            var methodSyntx = studentList
                .Select(std => new { Student = std, AgeIn20 = std.Age + 20 })
                .Where(s => s.AgeIn20 < 40 && s.Student.Age > 12)
                .Select(s => s.Student);

            PrintStudent(queryExpression);

            Console.WriteLine("=======OfType=========");
            var listOfObjects = new object[] { "it's a string", 8, new Student { StudentName = "object", Age = 8 } };

            PrintStudent(listOfObjects.OfType<Student>());
            //PrintStudent(listOfObjects.Cast<Student>());

            Console.WriteLine("=========Sorting==========");
            PrintStudent(studentList.OrderBy(s => s.StudentName));

            Console.WriteLine("=========Grouping========");

            var groupedByAge = studentList.GroupBy(s => s.Age);

            foreach (IGrouping<int, Student> group in groupedByAge)
            {
                Console.WriteLine($"Group age: {group.Key}");

                PrintStudent(group);
                //PrintStudent(group.Where(s => s.StudentName.Contains("a"));
            }

            //studentArray.ToDictionary(s => s.Age);
            studentList.ToLookup(s => s.Age);


            Console.WriteLine("=====SelectMany========");
            OperatorExamples.SelectExample();

            Console.WriteLine("========JOIN======");
            OperatorExamples.JoinExample();

            Console.WriteLine("Deferred vs Eager");
            PrintStudent(studentList);

            Console.WriteLine("-------");
            var filteredStudents = studentList
                .Where(s => s.Age > 21)
                .Select(s => new { Age = s.Age, Student = s })
                .Where(d => d.Age < 18)
                .Select(s => s.Student)
                .ToList();
            PrintStudent(filteredStudents);

            Console.WriteLine("-------");
            studentList.Add(new Student() { StudentID = 88, StudentName = "John", Age = 24 });
            PrintStudent(filteredStudents);

            Console.WriteLine("======Aggregation=====");
            var countOfStudent = studentList.Where(s => s.Age > 21).Count();
            Console.WriteLine($"Count: {countOfStudent}");
            var integers = new int[] { 8, 3, 10 };
            Console.WriteLine($"Min/Max: {integers.Min()}/{integers.Max()}");
            var oldestStudent = studentList.Max(s => s.Age);
            var sum = integers.Sum();
            var sumOfAge = studentList.Where(s => s.Age > 21).Average(s => s.Age);

            Console.WriteLine("======Element operator=====");
            var yougestStudent = studentList.OrderBy(s => s.Age).First();
            Console.WriteLine(yougestStudent);
            var studentWithCenturyAge = studentList.FirstOrDefault(s => s.Age > 100);

            //var onlyStudent18YearsOld = studentList.SingleOrDefault(s => s.Age == 21);

            Console.WriteLine("=====Set operators======");
            var duplicates = new int[] { 8, 3, 8, 10, 11 };
            duplicates.Distinct().OfType<object>().PrintObjects();

            Console.WriteLine();
            var except3And10And11 = duplicates.Except(new int[] { 3, 10, 11 });
            except3And10And11.OfType<object>().PrintObjects();

            if (studentList.Any(s => s.Age > 80))
            {
                Console.WriteLine("Congrats for 80 year old");
            }

            if (studentList.All(s => s.Age >= 18))
            {
                Console.WriteLine("Everyone is an adult");
            }

            Console.WriteLine((new int[0]).All(i => i > 8));

            Console.WriteLine("IEnumerable vs IQuerable");
            var studetsTable = studentList.AsQueryable();
            var filteredStudentsByAge = studetsTable.Where(s => s.Age > 21).ToList();
            var moreFilteringOnTable = filteredStudentsByAge.First(s => s.StudentName == "John"); // bad, build more specific query above.

            Console.WriteLine("====Contains or Except====");
            var words = new[] { "sun", "moon", "C# is bad", "mars", "JAVA" };
            var forbiddenWords = new[] { "C# is bad", "JAVA" };
            
            var allowedWords = words.Except(forbiddenWords);
            // or
            allowedWords = words.Where(w => !forbiddenWords.Contains(w));
        }

        public static void PrintStudent(IEnumerable<Student> students)
        {
            foreach (var item in students)
            {
                Console.WriteLine(new { item.StudentID, item.StudentName, item.Age });
            }
        }

        public static void PrintObjects(this IEnumerable<object> students)
        => students.ToList().ForEach(s => Console.WriteLine(s));


    }
}
