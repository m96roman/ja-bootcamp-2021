using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace KFedak_T10
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await SimulateGit();

            await Analyzer();
        }

        static async Task SimulateGit()
        {
            var listOfThreads = new List<Task>();

            Git git = new Git();

            for (int i = 0; i < 8; i++)
            {
                var developerId = i;

                listOfThreads.Add(Task.Run(() => CommitsPerDay(git, developerId)));
            }

            await Task.WhenAll(listOfThreads);

            Console.WriteLine($"Count of commits: {git.list.Count}");
        }

        public static void CommitsPerDay(Git git, int developer)
        {
            for (int i = 0; i < 88; i++)
            {
                git.Push($"The commit: {i + 1} was pushed by {developer}");
            }
        }

        static async Task Analyzer()
        {
            var httpClinet = new HttpClient();
            var text = await httpClinet.GetStringAsync("https://www.gutenberg.org/files/30155/30155-0.txt");
            char[] seperators = { ' ', ',', '.', ':', '\t', '\n', '\r', '\\', '/', '!', '?' };
            var wordsOfText = text.Split(seperators);

            await Task.WhenAll(OperationWithHttpClient.SaveInFile(text), OperationWithHttpClient.LongestWord(wordsOfText), OperationWithHttpClient.CommonWord(wordsOfText), OperationWithHttpClient.CountOfUsedWord(wordsOfText));
        }

        public class Git
        {
            public ConcurrentBag<string> list = new();

            public void Push(string message)
            {
                list.Add(message);
            }
        }

        public class OperationWithHttpClient
        {
            public static async Task SaveInFile(string text)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "info.txt");

                await File.WriteAllTextAsync(path, text);

                Console.WriteLine("Save in file");
            }

            public static async Task<string> LongestWord(string[] words)
            {
                var result = await Task.Run(() => words.OrderByDescending(x => x.Length).First());

                Console.WriteLine($"Find the longest word in this book: {result}");

                return result;
            }

            public static async Task<IEnumerable<string>> CommonWord(string[] text)
            {
                var result = await Task.Run(() => text
                     .GroupBy(s => s)
                     .Where(g => g.Count() > 1)
                     .OrderByDescending(g => g.Count())
                     .Select(g => g.Key).Take(8));

                Console.WriteLine($"Find top 8 most common words used:\n{string.Join(Environment.NewLine, result)}\n");

                return result;
            }

            public static async Task<int> CountOfUsedWord(string[] text)
            {
                var result = await Task.Run(() => text.Where(g => g.Equals("Relativity")).Count());

                Console.WriteLine($"Find how many times the word \"Relativity\" is used : {result}");

                return result;
            }
        }
    }
}
