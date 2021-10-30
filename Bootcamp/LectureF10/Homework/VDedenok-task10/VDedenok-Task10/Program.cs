using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;

namespace VDedenok_Task10
{
    class Program
    {
        static List<string> commits = new List<string>();

        static async Task Main(string[] args)
        {
            Console.WriteLine("-----Task1-----");
          
            List<Task> users = new List<Task>();

            StartWork workingDay = new StartWork();
          
            await workingDay.Start(users, commits);
      
            Task.WaitAll(users.ToArray());

            Console.WriteLine($"Total count of 88 commits, done by 8 users is {commits.Count}.");

           
            Console.WriteLine("-----Task2-----");
            bool exists = false;
            using var client = new HttpClient();
            string content = "";
            string fullPath = @$"{Directory.GetCurrentDirectory()}\Relativity.txt";

            while (!exists)
            {
                try
                {
                    content = await client.GetStringAsync("https://www.gutenberg.org/files/30155/30155-0.txt");
                    exists = true;
                }
                catch (Exception)
                {
                    throw;
                }
            }

            File.WriteAllText(fullPath, content);

            string textToWords = File.ReadAllText(fullPath).ToLower();
            char[] charSplit = new char[] { '\n', '\r', ' ', '\"', '/', '\\', '*', '!', '?', '\t', '-', '+', '.', ',', '$', '(', ')', '{', '}', '@', '#', '%', '^', '&', '<', '>', '`' };
            string[] splitedText = textToWords.Split(charSplit, StringSplitOptions.RemoveEmptyEntries);

            RelativityTheory theory = new RelativityTheory();

            await theory.DoAllAnalize(splitedText);
        }
    }
}