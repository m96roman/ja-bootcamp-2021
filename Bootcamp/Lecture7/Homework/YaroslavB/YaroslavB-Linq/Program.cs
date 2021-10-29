using System;
using System.Collections.Generic;
using System.Linq;

namespace YaroslavB_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.  Write a program in C# Sharp to find the number of an array and the square of each number.
            Console.WriteLine("Subtask 1:\n");
            Console.WriteLine("Output:");

            var array = new int[] { 9, 8, 6, 5 };
            var newArr = array.Select(n => new { Number = n, SqrNo = Math.Pow(n, 2) });

            foreach (var item in newArr)
            {
                Console.WriteLine("{" + $" {nameof(item.Number)} = {item.Number}, {nameof(item.SqrNo)} = {item.SqrNo} " + "}");
            }

            Console.WriteLine("\n-------------------------------------------------------------------\n");


            //2.  Write a program in C# Sharp to display the characters and frequency of character from giving string.
            Console.WriteLine("\nSubtask 2:\n");
            Console.WriteLine("Output:");

            string inputString = "apple";

            Char[] chars = inputString.ToCharArray();
            var charsFeq = chars.GroupBy(c => c).Select(g => new { Char = g.Key, Frequency = g.Count() });

            foreach (var item in charsFeq)
            {
                Console.WriteLine($"Character {item.Char}: {item.Frequency} times");
            }

            Console.WriteLine("\n-------------------------------------------------------------------\n");


            //3. Write a program in C# Sharp to convert a string array to a string.
            Console.WriteLine("\nSubtask 3:\n");
            Console.WriteLine("Output:");

            var animals = new string[] { "cat", "dog", "rat" };
            var animalsString = animals.Aggregate((x, y) => x + ", " + y);

            Console.WriteLine(animalsString);

            Console.WriteLine("\n-------------------------------------------------------------------\n");


            //4. Students and faculties structure.
            Console.WriteLine("\nSubtask 4:\n");
            Console.WriteLine("All students and their grades:");

            var students = Deanery.GetStudents();
            var faculties = Deanery.GetFaculties();

            var studAndFaculty = students.Join(faculties,
                                    s => s.FacultyId,
                                    f => f.FacultyId,
                                    (s, f) => new { FacultyName = f.Name, StudentName = s.FirstName, AverageGrade = s.AverageGrade }
                                    );

            Console.WriteLine("   Faculty:  \tStudent:  \tAverageGrade:");

            int count = 1;

            foreach (var item in studAndFaculty)
            {
                Console.WriteLine($"{count,-2} {item.FacultyName,-16}{item.StudentName,-16}{item.AverageGrade}");
                count++;
            }

            var groupsPerFaculty = studAndFaculty.GroupBy(s => s.FacultyName)
                                                 .Select(g => g.OrderByDescending(s => s.AverageGrade));

            Console.WriteLine("\n\nStudents per Faculty:");

            foreach (var group in groupsPerFaculty)
            {
                Console.WriteLine($"------ {group.First().FacultyName} ------");
                foreach (var item in group)
                {
                    Console.WriteLine($" {item.StudentName} - grade: {item.AverageGrade}");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nMaxGrades per Faculty:");
            Console.WriteLine("Faculty:\t Students:");

            var maxGrades = groupsPerFaculty.Select(g => new 
            {
                Faculty = g.First().FacultyName,
                Student = g.First().StudentName,
                MaxGrade = g.First().AverageGrade 
            });

            foreach (var item in maxGrades)
            {
                Console.WriteLine($"{item.Faculty,-16} {item.Student + ",",-8} MaxGrade: {item.MaxGrade}");
            }

            Console.WriteLine($"\nAverage Grade per Faculty:");
            var aveGrade = groupsPerFaculty.Select(g => new
            {
                Faculty = g.First().FacultyName,
                AverageGrade = g.Average(s => s.AverageGrade)
            });

            foreach (var item in aveGrade)
            {
                Console.WriteLine($"{item.Faculty,-16} {item.AverageGrade: #.##}");
            }


            Console.WriteLine();

            //Adding additional students and getting same names
            students.AddRange(new Student[] 
            {
                new Student(42, 201, "Nicole", 3.5),
                new Student(44, 202, "Adam", 3.5),
                new Student(46, 202, "Adam", 2.5),
                new Student(48, 203, "Amy", 3.5)
            });

            var sameNames = studAndFaculty.GroupBy(s => s.StudentName)
                                    .Where(g => g.Count() > 1)
                                    .Sum(g => g.Count());

            Console.WriteLine($"\n\nSum of students with the same name: {sameNames}");
            Console.WriteLine($"\nFaculties and student names:");

            var tempList = students.Join(faculties, 
                                      s => s.FacultyId,
                                      f => f.FacultyId,
                                      (s, f) => new 
                                      { 
                                          FacultyName = f.Name, 
                                          StudentName = s.FirstName, 
                                          Grade = s.AverageGrade 
                                      })
                                    .GroupBy(l => l.FacultyName);
          
            foreach (var group in groupsPerFaculty)
            {
                Console.WriteLine($"------{group.First().FacultyName}:");
                foreach (var item in group)
                {
                    Console.WriteLine($" {item.StudentName}");
                }
                Console.WriteLine();
            }

            var sameNamesPerFaculty = studAndFaculty.GroupBy(s => s.FacultyName)
                                     .Select(g => new
                                     {
                                         FacultyName = g.Key,
                                         Int = g.GroupBy(s => s.StudentName)
                                         .Where(g => g.Count() > 1)
                                         .Sum(g => g.Count())
                                     });

            Console.WriteLine("\n\nSum of the same students names per faculty name:");

            foreach (var item in sameNamesPerFaculty)
            {
                Console.WriteLine($" Faculty: {item.FacultyName}, the same names: {item.Int}");
            }

            Console.WriteLine("\n\nPress \'Enter\' to exit");
            Console.ReadLine();
        }
    }
}
