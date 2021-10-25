using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.Diagnostics;
using System.Net.Http;
using System.IO;

namespace Shyptur_Task10HW
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Task1();

            // await Task2();
        }

        static async Task Task2()
        {
            var httpClinet = new HttpClient();
            var text = await httpClinet.GetStringAsync("https://www.gutenberg.org/files/30155/30155-0.txt");
            char[] charSplit = new char[] { '\n', '\r', ' ', '\"', '/', '\\', '*', '!', '?', '\t', '-', '+', '.', ',', '$', '(', ')', '{', '}', '@', '#', '%', '^', '&', '<', '>', '`' };
            string[] a = text.Split(charSplit, StringSplitOptions.RemoveEmptyEntries);

            await Task.WhenAll(Task21(text), Task22(a), Task23(a), Task24(a));

        }

        public static async Task Task21(string text)
        {
            await File.WriteAllTextAsync("Relativity: The Special and General Theory.txt", text);
        }

        public static async Task Task22(string[] array)
        {
            var longestWoerd = array
                  .Where(length => length.Length > 5)
                  .OrderBy(s => s.Length)
                  .Last();

            Console.WriteLine($" Find the longest word in this book, the word must be longer than 5 characters to participate in the challenge?  IS - {longestWoerd}");
        }

        public static async Task Task23(string[] array)
        {
            var MostCommonWordsUsed = array.GroupBy(s => s);
            MostCommonWordsUsed = MostCommonWordsUsed.OrderByDescending(s => s.Count());
            int count = 0;
            Console.WriteLine("Find top 8(obviously) most common words used.");
            MostCommonWordsUsed = MostCommonWordsUsed.Take(8);

            foreach (var item in MostCommonWordsUsed)
            {
                Console.WriteLine($"word {count} - {item.Key} "); ;
                count += 1;
            }
        }

        public static async Task Task24(string[] array)
        {
            var result = array.Count(t => t.Equals("relativity", StringComparison.CurrentCultureIgnoreCase));
            Console.WriteLine(" Find how many times the word 'Relativity' is used?  - " + result);
        }

        static async void Task1()
        {
            Git git = new Git();
            var listOfThreads = new List<Task>();

            for (int i = 0; i < 8; i++)
            {
                listOfThreads.Add(Task.Run(() => PushUse(git)));
            }
            Console.WriteLine("lol");
            await Task.Run(() => Task.WaitAll(listOfThreads.ToArray()));
            //  Task.WaitAll(listOfThreads.ToArray());
            Console.WriteLine(git.commits.Count);
        }

        public static void PushUse(Git git)
        {
            for (int i = 0; i < 88; i++)
            {
                git.Push(i.ToString());
            }
        }
    }
}
