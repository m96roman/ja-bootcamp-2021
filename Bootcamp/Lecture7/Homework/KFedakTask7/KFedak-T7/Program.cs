using System;
using System.Collections.Generic;
using System.Linq;

namespace KFedak_T7
{
    /// <summary>
    ///  Write a program in C# Sharp to find the number of an array and the square of each number.
    //    Expected Output :
    //{ Number = 9, SqrNo = 81 }
    //{ Number = 8, SqrNo = 64 }
    //{ Number = 6, SqrNo = 36 }
    //{ Number = 5, SqrNo = 25 }
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task1\n");

            var result = new List<int>() { 6, 7, 8 }.Select(n => new { number = n, squera = n * n }).ToList();

            foreach (var el in result)
            {
                Console.WriteLine($"Number = {el.number}, SqrNo = {el.squera}");
            }

            Console.WriteLine("\nTask2\n");

            var st = "apple";

            var characterList = st.GroupBy(c => c).Select(letter => new { letter, count = letter.Count() }).ToList();

            foreach (var el in characterList)
            {
                Console.WriteLine($"Character {el.letter.Key}: {el.count} times");
            }

            Console.WriteLine("\nTask3\n");

            var st1 = new[] { "cat", "dog", "rat" };

            var stringList = st1.Select(s => s).Aggregate((i, j) => i + "," + j);

            Console.WriteLine(stringList);

            Console.WriteLine("\nTask5\n");

            Linq.StudentsWithMaxGradePerFaculty();

            Console.WriteLine("\nStudents with the same name\n");

            Linq.SameName();

            Console.WriteLine("\nStudents with the same name per faculty\n");

            Linq.SameNamePerFaculty();
        }
    }
}
