using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.Diagnostics;
using System.Net.Http;

namespace Shyptur_Task10HW
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //  Task1();

            var httpClinet = new HttpClient();
            var text = await httpClinet.GetStringAsync("https://www.gutenberg.org/files/30155/30155-0.txt");
            Console.WriteLine(text);
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
