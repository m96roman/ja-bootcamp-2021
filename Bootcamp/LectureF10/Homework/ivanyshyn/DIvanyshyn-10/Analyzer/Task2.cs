using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DIvanyshyn_10.Analyzer
{
    class Task2
    {
        private static readonly string requestUri = "https://www.gutenberg.org/files/30155/30155-0.txt";

        public static async Task ExecuteAsync()
        {
            var client = new HttpClient();
            var response = await client.GetStringAsync(requestUri);

            char[] separators = { ' ', ',', '.', ':', '\t', '\n', '\r', '\\', '/', '!', '?' };
            var words = response.Split(separators).Where(w => !string.IsNullOrWhiteSpace(w));

            var path = Path.Combine(Directory.GetCurrentDirectory(), "Einstein.txt");
            await File.WriteAllTextAsync(path, response);

            Console.WriteLine($"File saved in {path}");

            Parallel.Invoke(() =>
            {
                var longestWord = words.Where(w => w.Length > 5).OrderByDescending(w => w.Length).First();

                Console.WriteLine($"Longest word is {longestWord}");
            }, () =>
            {
                //Why 8? this is some code number? just curios
                var top8 = words
                  .GroupBy(w => w)
                  .OrderByDescending(group => group.Count())
                  .Take(8)
                  .Select(w => w.Key);

                Console.WriteLine($"Most common words is: {string.Join(", ", top8)}");
            }, () =>
            {
                var count = words.Count(w => w.Equals("Relativity"));

                Console.WriteLine($"Count of times the word 'Relativity' is used {count}");
            });
        }
    }
}



