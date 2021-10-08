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
        static void Main(string[] args)
        {
            //  Task1();

            Task2().GetAwaiter().GetResult();

        }

        static async Task Task2()
        {
            var httpClinet = new HttpClient();
            var text = await httpClinet.GetStringAsync("https://www.gutenberg.org/files/30155/30155-0.txt");
            char[] ar = new char[] { '\n', '\r', ' ', '\"', '/', '\\', '*', '!', '?', '\t', '-', '+', '.', ',', '$', '(', ')', '{', '}', '@', '#', '%', '^', '&', '<', '>', '`' };
            string[] a = text.Split(ar, StringSplitOptions.RemoveEmptyEntries);
            Task22(a);
            Task23(a);
            Task24(a);

        }
        public static void Task22(string[] array)
        {
            var longestWoerd = array
                  .Where(length => length.Length > 5)
                  .OrderBy(s => s.Length).Last();
            Console.WriteLine(longestWoerd);
        }
        public static void Task23(string[] array)
        {
            var MostCommonWordsUsed = array.GroupBy(s => s);
            MostCommonWordsUsed.OrderBy(s=>s.c)
            int count = 0;
            foreach (var item in MostCommonWordsUsed)
            {
                Console.WriteLine(item.Key);
                count += 1;
                if (count==8)
                {
                    break;
                }
            }
        }

        public static void Task24(string[] array)
        {
            var HowManyTimes = array.Where(s => s == "Relativity" || s== "RELATIVITY").Count();
            Console.WriteLine(" Find how many times the word 'Relativity' is used?  - "+HowManyTimes.ToString());
        }
        static void Task1()
        {
            Git git = new Git();
            var listOfThreads = new List<Task>();

            for (int i = 0; i < 8; i++)
            {
                listOfThreads.Add(Task.Run(() => PushUse(git)));
            }

            Task.WaitAll(listOfThreads.ToArray());
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
