using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ADovhanych_Task10._2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Handler();
        }

        static async Task Handler()
        {
            var httpClient = new HttpClient();
            string file = await httpClient.GetStringAsync("https://www.gutenberg.org/files/30155/30155-0.txt");
            List<string> words = new List<string>(file
                .Split(new char[] { '\t', '\n', '\r', '\\', '/', ' ', ',', '.', ':', '-' }, StringSplitOptions.RemoveEmptyEntries));

            Parallel.Invoke(() =>
            {
                string dir = Directory.GetCurrentDirectory();
                string destination = Path.Combine(dir, "Book.txt");

                File.WriteAllTextAsync(destination, file);
                Console.WriteLine($"Text is saved to Book.txt in {destination}");

            }, () =>
            {
                string longest = words.OrderByDescending(s => s.Length).First();
                Console.WriteLine($"The longest word in the file is: {longest}");
            }, () =>
            {
                int counter = words.Count(word => word.Equals("Relativity"));
                Console.WriteLine($"Relativity is used: {counter} times");
            }, () =>
            {
                var topCommonWords = words
                   .GroupBy(word => word)
                   .Select(word => new
                   {
                       Field = word.Key,
                       Count = word.Count()
                   })
                   .OrderByDescending(word => word.Count)
                   .Take(8);

                int place = 1;

                foreach(var item in topCommonWords)
                { 
                    Console.WriteLine($"Top {place} most used word is {item.Field} - {item.Count}");
                    place++;
                }
            });
        }
    } 
}
