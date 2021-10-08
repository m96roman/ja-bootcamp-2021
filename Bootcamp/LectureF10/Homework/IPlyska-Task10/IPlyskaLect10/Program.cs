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

            //for (int i = 0; i < 88; i++)
            //{
            //    Git.WorkWithGit(Git.CreateDevs());
            //}

            //Git.ShowAllCommits();
            //Console.ReadKey();

            HttpClient client = new HttpClient();

            Relativity relativity = new Relativity();

                relativity.Gettext(client).Wait();

                relativity.SaveText();
                relativity.FindLongestWord();
                relativity.CountOneWord("Relativity");
                relativity.TopWordUsed();

            Console.ReadKey();
            
        }
    }
}
