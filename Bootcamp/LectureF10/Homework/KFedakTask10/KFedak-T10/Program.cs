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
            SimulateGit();

            await Analyzer();
        }

        static void SimulateGit()
        {
            var listOfThreads = new List<Task>();

            Git git = new Git();

            for (int i = 0; i < 8; i++)
            {
                var developerId = i;

                listOfThreads.Add(Task.Run(() => git.Push("commit", developerId)));
            }

            Task.WaitAll(listOfThreads.ToArray());

            Console.WriteLine($"Count of commits: {git.list.Count}");
        }

        static async Task Analyzer()
        {
            var httpClinet = new HttpClient();
            var text = await httpClinet.GetStringAsync("https://www.gutenberg.org/files/30155/30155-0.txt");
            await Task.WhenAll(OperationWithHttpClient.SaveInFile(text), OperationWithHttpClient.LongestWord(text), OperationWithHttpClient.CommonWord(text), OperationWithHttpClient.CountOfUsedWord(text));
        }

        public class Git
        {
            public ConcurrentBag<string> list = new();

            public void Push(string message, int developer)
            {
                for (int i = 0; i < 88; i++)
                {
                    list.Add($"{message} {i} by :{developer}");
                }
            }
        }

        public class OperationWithHttpClient
        {
            public static async Task SaveInFile(string text)
            {
                using var file = File.Create($@"{Directory.GetCurrentDirectory()}\info.txt");
                using var writer = new StreamWriter(file);
                await writer.WriteLineAsync(text);

                Console.WriteLine("Save in file");
            }

            public static Task<string> LongestWord(string text)
            {
                char[] seperators= { ' ', ',', '.', ':', '\t', '\n', '\r', '\\', '/', '!', '?' };
                var result = Task.Run(() => text.Split(seperators).OrderByDescending(x => x.Length).FirstOrDefault());

                Console.WriteLine($"Find the longest word in this book: {result.Result}");

                return result;
            }

            public static Task<IEnumerable<string>> CommonWord(string text)
            {
                var result = Task.Run(() => text.Split(' ')
                    .GroupBy(s => s)
                    .Where(g => g.Count() > 1)
                    .OrderByDescending(g => g.Count())
                    .Select(g => g.Key).Take(8));

                Console.WriteLine($"Find top 8 most common words used:\n{string.Join(Environment.NewLine, result.Result)}\n");

                return result;
            }

            public static Task<int> CountOfUsedWord(string text)
            {
                var result = Task.Run(() => text.Split(' ').Where(g => g == "Relativity").Count());

                Console.WriteLine($"Find how many times the word \"Relativity\" is used : {result.Result}");

                return result;
            }
        }
    }
}
