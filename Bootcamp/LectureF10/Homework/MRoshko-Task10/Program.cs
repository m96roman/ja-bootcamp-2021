using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MRoshko_Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();

            Task2();
        }

        public static void Task1()
        {
            var git = new Git();

            for (int i = 0; i < 8; i++)
            {
                var developer = new Thread(() => CommitsDay(git));
                developer.Start();
                developer.Join();
            }

            Console.WriteLine(git.bucketList.Count);
        }

        public static void Task2()
        {
            Analyzer().GetAwaiter().GetResult();
        }

        public static async Task Analyzer()
        {
            string url = "https://www.gutenberg.org/files/30155/30155-0.txt";

            char[] separators = ($".,#-_*&?@:;.\\/'\"\n\t\r! ")
                .ToCharArray();

            var file = await new HttpClient()
                .GetStringAsync(url);

            if (File.Exists($@"{Directory.GetCurrentDirectory()}\OutPut.txt"))
            {
                await File.WriteAllTextAsync($@"{Directory.GetCurrentDirectory()}\OutPut.txt", file);
            }

            var filepath = Path.Combine(Directory.GetCurrentDirectory(), "OutPut.txt");

            await File.WriteAllTextAsync(filepath, file);

            string[] stringOfWords = file
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            await  FindTheLongestWord(stringOfWords);

            await  FindTopMostCommonWords(stringOfWords);

            await FindWordRepeatTimes(stringOfWords);
        }

        public static Task FindTopMostCommonWords(string[] file)
        {
            var topWords = file
                  .GroupBy(s => s)
                  .OrderByDescending(group => group.Count())
                  .Take(8)
                  .Select(s => s.Key)
                  .ToList();

            Console.Write($"\nTop 8 most common words is:\n");

            foreach (var item in topWords)
            {
                Console.WriteLine($"{item}");
            }

            return Task.CompletedTask;
        }

        public static Task FindWordRepeatTimes(string[] file)
        {
            var count = file
                .Count(s => s.Equals("relativity", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine($"\n'Relativity' word is repeat {count} times.");

            return Task.CompletedTask;
        }

        public static Task FindTheLongestWord(string[] file)
        {
            var finalValue = file
                .Where(s => s.Length > 5)
                .OrderByDescending(n => n.Length)
                .First();

            Console.WriteLine("Largest word is: " + finalValue);

            return Task.CompletedTask;
        }

        public static void CommitsDay(Git git)
        {
            for (int j = 0; j < 88; j++)
            {
                git.Push($"Commit {j}");
            }
        }
    }
}
