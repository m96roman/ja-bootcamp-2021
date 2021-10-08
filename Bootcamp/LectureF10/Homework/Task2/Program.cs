using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;

namespace Task2
{
    class Program
    {
        public static string pathSaveBook = $@"C:\Projects\Lecture 10 .Net\Task2\book.txt";
        static async Task Main(string[] args)
        {
            string document = await GetDocumentAsync();

            string[] book = await ConvertStringIntoArray(document);

            await Task.WhenAll(SaveIntoFile(document), FindLongestWord(book), FindMostCommonWords(book), HowManyTime(book));
        }

        static async Task HowManyTime(string[] textFromFile)
        {
            string findWord = "Relativity";

            int amountHowMany = textFromFile.Where(x => x.ToLowerInvariant() == findWord.ToLowerInvariant()).Count();

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

        static async Task<string[]> ConvertStringIntoArray(string document)
        {
            return document.Split(
                           new[] { ' ', '\n', '\r', ',', ';', ':', '.', '!', '?', '-', '/', '\\', '—', '_' },
                           StringSplitOptions.RemoveEmptyEntries
                           );
        }

        static async Task SaveIntoFile(string doc)
        {
            using (var filecreate = File.Create(pathSaveBook));

            using (StreamWriter writer = new StreamWriter(pathSaveBook))
            {
                await writer.WriteAsync(doc);
            }
        }

        static async Task<string> GetDocumentAsync()
        {
            var httpClinet = new HttpClient();
            return await httpClinet.GetStringAsync("https://www.gutenberg.org/files/30155/30155-0.txt");
        }
    }
}
