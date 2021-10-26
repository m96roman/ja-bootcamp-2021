using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;

namespace Task2
{
    class Program
    {
        public static readonly string pathSaveBook = $@"{Directory.GetCurrentDirectory()}book.txt";

        static async Task Main(string[] args)
        {
            string document = await GetDocumentAsync();

            string[] book = ConvertStringIntoArray(document);

            await Task.WhenAll(SaveIntoFile(document), FindLongestWord(book), FindMostCommonWords(book), HowManyTime(book));
        }

        static async Task HowManyTime(string[] textFromFile)
        {
            string findWord = "Relativity";

            int amountHowMany = textFromFile.Where(x => x.Equals(findWord, StringComparison.OrdinalIgnoreCase)).Count();

            Console.WriteLine($"How many time word {findWord} is used in book -> {amountHowMany}");
        }

        static async Task FindMostCommonWords(string[] textFromFile)
        {
            var commonWords = textFromFile.GroupBy(x => x).Where(x => x.Count() > 1).OrderByDescending(x => x.Count()).Take(8);

            Console.WriteLine("Most common words: ");
            foreach(var word in commonWords)
            {
                Console.WriteLine(word.Key);
            }
        }

        static async Task FindLongestWord(string[] textFromFile)
        {
            string word = textFromFile.OrderByDescending(x => x.Length).Where(x => x.Length > 5).First();

            Console.WriteLine($"Longest word in the book -> {word}");
        }

        static string[] ConvertStringIntoArray(string document)
        {
            return document.Split(
                           new[] { ' ', '\n', '\r', ',', ';', ':', '.', '!', '?', '-', '/', '\\', '—', '_' },
                           StringSplitOptions.RemoveEmptyEntries
                           );
        }

        static async Task SaveIntoFile(string doc)
        {
            File.WriteAllTextAsync(pathSaveBook, doc);
        }

        static async Task<string> GetDocumentAsync()
        {
            var httpClinet = new HttpClient();
            return await httpClinet.GetStringAsync("https://www.gutenberg.org/files/30155/30155-0.txt");
        }
    }
}
