using System;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string: ");
            string testData = Console.ReadLine();

            var frequency = from ch in testData
                            group ch by ch into freq
                            select new { Character = freq.Key, Frequency = freq.Count() };

            foreach (var item in frequency)
            {
                Console.WriteLine($"Character = {item.Character}, SqrNo = {item.Frequency}");
            }
        }
    }
}
