using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Task10_Part2
{
    class ContentAnalyzer
    {
        private string _content = "";
        private char[] divider = { ' ', '\t', '\n', '\r', '.', ',', '!', '?', '\\', '/', '-', ':', ';', '(', ')', '[', ']', '\"', '—', '_' };

        public const string DefaultPath = "..\\..\\..\\";

        public async void DownloadTextAsync(string url, string fileName, string pathToSave = DefaultPath)
        {
            string fullPath = Path.Combine(pathToSave, fileName);
            _content = GetContent(url);
            await SaveDataToFile(_content, fullPath);
        }

        public string GetLongestWord()
        {
            var allWords = _content.Split(divider, StringSplitOptions.RemoveEmptyEntries);

            var longestWord = allWords.Where(w => w.Length > 5)
                                      .OrderByDescending(w => w.Length)
                                      .First();

            return longestWord;
        }

        public Dictionary<string, int> GetTopUsedWords(int topNumber = 10)
        {
            string[] allWords = _content.Split(divider, StringSplitOptions.RemoveEmptyEntries);

            var topWords = allWords.GroupBy(w => w)
                               .OrderByDescending(g => g.Count())
                               .Take(topNumber)
                               .ToDictionary(g => g.Key, g => g.Count());

            return topWords;
        }

        public int GeNumberOfTimesUsed(string word)
        {
            var allWords = _content.Split(divider, StringSplitOptions.RemoveEmptyEntries);
            var number = allWords.Where(w => w.Equals(word, StringComparison.OrdinalIgnoreCase))
                                 .Count();

            return number;
        }

        private string GetContent(string url)
        {
            var httpClinet = new HttpClient();
            return httpClinet.GetStringAsync(url).Result;
        }

        private async Task SaveDataToFile(string data, string path)
        {
            await File.WriteAllTextAsync(path, data);
        }
    }
}
