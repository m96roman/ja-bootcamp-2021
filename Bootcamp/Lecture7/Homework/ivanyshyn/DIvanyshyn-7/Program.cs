using DIvanyshyn_7.Task3;
using System;
using System.Linq;
using Task2_Ivanyshyn.Helpers;

namespace DIvanyshyn_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            Task4.Execute();
        }

        /// <summary>
        /// Write a program in C# Sharp to find the number of an array and the square of each number.
        ///Expected Output :
        ///{ Number = 9, SqrNo = 81 }
        ///{ Number = 8, SqrNo = 64 }
        ///{ Number = 6, SqrNo = 36 }
        ///{ Number = 5, SqrNo = 25 }
        /// </summary>
        private static void Task1()
        {
            int[] numbers = new int[20];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }

            var squaresAndNumbers = numbers.Select(n => new { Number = n, Square = Math.Pow(n, 2) }).ToList();

            Console.WriteLine(String.Join("\n", squaresAndNumbers));
        }

        ///<summary>
        /// Write a program in C# Sharp to display the characters and frequency of character from giving string.
        ///Test Data:
        ///Input the string: apple
        ///Expected Output:
        ///The frequency of the characters are :
        ///Character a: 1 times
        ///Character p: 2 times
        ///Character l: 1 times
        ///Character e: 1 times
        ///</summary>
        private static void Task2()
        {

            var str = Reader.ReadString();

            var dict = str.GroupBy(c => c).ToDictionary(c => c.Key, c => c.Count());

            Console.WriteLine("The frequency of the characters are :");
            foreach (var item in dict)
            {
                Console.WriteLine($"Character {item.Key}: {item.Value} times");
            }
        }

        /// <summary>
        ///  Write a program in C# Sharp to convert a string array to a string.
        ///Test Data :
        ///Input number of strings to store in the array :3
        ///Input 3 strings for the array :
        ///Element[0] : cat
        ///Element[1] : dog
        ///Element[2] : rat
        ///Expected Output:
        ///Here is the string below created with elements of the above array :
        ///cat, dog, rat
        /// </summary>
        private static void Task3()
        {
            var count = Reader.ReadNumber("Input number of strings to store in the array :");

            string[] strings = new string[count];
            for (int i = 0; i < count; i++)
            {
                strings[i] = Reader.ReadString($"Element[{i}]");
            }
            string aggregated = "";
            try
            {
                aggregated = strings.Aggregate(
                     (current, next) => current + ", " + next);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("The string array is empty!");

                return;
            }

            Console.WriteLine(aggregated);
        }
    }
}
