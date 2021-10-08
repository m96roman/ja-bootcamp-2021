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


            //3. Write a program in C# Sharp to convert a string array to a string.
            Console.WriteLine("\nSubtask 4:\n");
            Console.WriteLine("All students and their grades:");

            var students = Deanery.GetStudents();
            var faculties = Deanery.GetFaculties();

            var groups = students.GroupBy(s => s.FacultyId)
                                 .Select(g => g.OrderByDescending(s => s.AverageGrade));

            foreach (var item in groups)
            {
                Console.WriteLine("------");
                foreach (var item2 in item)
                {
                    Console.WriteLine($" FacultID: {item2.FacultyId}, Student: {item2.FirstName} - grade: {item2.AverageGrade}");
                }
            }

            var maxGrades = groups.Select(g => new 
            { 
                FacultyId = g.First().FacultyId,
                Student = g.First().FirstName,
                MaxGrade = g.First().AverageGrade 
            });

            Console.WriteLine($"\n\nMaxGrades per FacultyId:");
            foreach (var item in maxGrades)
            {
                Console.WriteLine($" FacultyId: {item.FacultyId}, Student: {item.Student}, MaxGrade: {item.MaxGrade}");
            }

            Console.WriteLine($"\n\nFaculty and students with max grade:");

            var result = maxGrades.Join(faculties, 
                                        m => m.FacultyId,
                                        f => f.FacultyId,
                                        (m, f) => new { FacultyName = f.Name, StudentName = m.Student });

            foreach (var item in result)
            {
                Console.WriteLine($" FacultyName: {item.FacultyName}, StudentName: {item.StudentName}");
            }

            

            //Adding additional students and getting same names

            students.AddRange(new Student[] 
            {
                new Student(42, 201, "Nicole", 3.5),
                new Student(44, 202, "Adam", 3.5),
                new Student(46, 202, "Adam", 2.5),
                new Student(48, 203, "Amy", 3.5)
            });

            //var groups2 = students.GroupBy(s => s.FacultyId)
            //                     .Select(g => g.OrderByDescending(s => s.AverageGrade));

            //Console.WriteLine($"------ Group items {groups2.Count()} ---------");
            //foreach (var item in groups2)
            //{
            //    Console.WriteLine($"------ Subgroup items {item.Count()} ---------");
            //    foreach (var item2 in item)
            //    {
            //        Console.WriteLine($"FacultID: {item2.FacultyId}, Student {item2.FirstName} - grade: {item2.AverageGrade}");
            //    }
            //}

            var sameNames = students.GroupBy(s => s.FirstName)
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
          
            foreach (var item in tempList)
            {
                Console.WriteLine("------");
                foreach (var itemIn in item)
                {
                    Console.WriteLine($" Faculty: {itemIn.FacultyName}, student name: {itemIn.StudentName}");
                }
            }

            var list4 = tempList.Select(g => new
                                            { 
                                                FacultyName = g.Key, 
                                                Int = g.GroupBy(s => s.StudentName)
                                                       .Where(g => g.Count() > 1)
                                                       .Sum(g => g.Count())
                                            });

            Console.WriteLine("\n\nSum of the same students names per faculty name:");

            foreach (var item in list4)
            {
                Console.WriteLine($" Faculty: {item.FacultyName}, the same names: {item.Int}");
            }

            Console.WriteLine("\n\nPress \'Enter\' to exit");
            Console.ReadLine();
        }
    }
}
