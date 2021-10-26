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
            var httpClient = new HttpClient();
            string file = await httpClient.GetStringAsync("https://www.gutenberg.org/files/30155/30155-0.txt");
            List<string> words = new List<string>(file
                .Split(new char[] { '\t', '\n', '\r', '\\', '/', ' ', ',', '.', ':', '-' }, StringSplitOptions.RemoveEmptyEntries));
            await Task.WhenAll(Task1(file), Task2(words), Task3(words), Task4(words));
        }

        public static async Task Task1(string file)
        {
            string dir = Directory.GetCurrentDirectory();
            string destination = Path.Combine(dir, "Book.txt");

            await File.WriteAllTextAsync(destination, file);
            Console.WriteLine($"Text is saved to Book.txt in {destination}");
        }

        public static async Task Task2(List<string> words)
        {
            await Task.Run(() =>
            {
                string longest = words.OrderByDescending(s => s.Length).First();
                Console.WriteLine($"The longest word in the file is: {longest}");
            });
        }
        
        public static async Task Task3(List<string> words)
        {
            await Task.Run(() =>
            {
                int counter = words.Count(word => word.Equals("Relativity", StringComparison.OrdinalIgnoreCase));
                Console.WriteLine($"Relativity is used: {counter} times");
            });
        }

        public static async Task Task4(List<string> words)
        {
            await Task.Run(() =>
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

                foreach (var item in topCommonWords)
                {
                    Console.WriteLine($"Top {place} most used word is {item.Field} - {item.Count}");
                    place++;
                }
            });
        }
    } 
}
