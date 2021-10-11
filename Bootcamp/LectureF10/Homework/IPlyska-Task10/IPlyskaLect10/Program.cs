using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace IPlyskaLect10
{
    class Program
    {
        static void Main(string[] args)
        {
            Git git = new Git();

            List<Task> tasks = new List<Task>();

            for (int i = 0; i < 8; i++)
            {
                tasks.Add(Task.Run(() => git.WorkWithGit(88)));
            }

            Task.WaitAll(tasks.ToArray());

            git.ShowAllCommits();

            Console.ReadKey();

            //HttpClient client = new HttpClient();

            //Relativity relativity = new Relativity();

            //    relativity.Gettext(client).Wait();

            //    relativity.SaveText();
            //    relativity.FindLongestWord();
            //    relativity.CountOneWord("Relativity");
            //    relativity.TopWordUsed();

            Console.ReadKey();
            
        }
    }
}
