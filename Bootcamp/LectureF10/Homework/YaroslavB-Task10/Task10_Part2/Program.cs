using System;
using System.Collections.Generic;
using System.Linq;

namespace Task10_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://www.gutenberg.org/files/30155/30155-0.txt";
            string fileName = "RelativityTheory.txt";
            string wordToGetTop = "Relativity";

            var bookAnalyzer = new ContentAnalyzer();
            bookAnalyzer.DownloadTextAsync(url, fileName);

            string longestWord = bookAnalyzer.GetLongestWord();
            Console.WriteLine($"Longest word: {longestWord}\n");

            Dictionary<string, int> topWords = bookAnalyzer.GetTopUsedWords(8);

            foreach (var item in topWords)
            {
                Console.WriteLine($"Word: {item.Key,-10} freq: {item.Value}");
            }

            int num = bookAnalyzer.GeNumberOfTimesUsed(wordToGetTop);
            Console.WriteLine($"\nWord \"{wordToGetTop}\" occurs - {num} times");

            Console.WriteLine("\n\nPress \'Enter\' to exit");
            Console.ReadLine();
        }
    }
}
