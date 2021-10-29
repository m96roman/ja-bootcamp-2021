using System;
using System.Linq;
using System.Threading.Tasks;

namespace VDedenok_Task10
{
    class RelativityTheory
    {
        public async Task CountRelativity(string[] text)
        {
            var relativityCount = text.Where(s => s == "relativity").Count();
            Console.WriteLine($"The word \"relativity\" appears {relativityCount} times in a text!");
        }

        public async Task LongestWord(string[] text)
        {
            var longestWord = text.OrderByDescending(x => x.Length).First();
            Console.WriteLine($"The longest word in a book is \"{longestWord}\"!");
        }

        public async Task MostUsedWords(string[] text)
        {
            var topUsedWords = text.GroupBy(i => i)
              .Select(grp => new
              {
                  word = grp.Key,
                  total = grp.Count()
              })
             .ToArray().OrderByDescending(w => w.total).Take(8);

            foreach (var item in topUsedWords)
            {
                Console.WriteLine($"One of the top 8 most common words is \"{item.word}\"!");
            }
        }

        public async Task DoAllAnalize(string[] text)
        {
            await Task.WhenAll(CountRelativity(text), LongestWord(text), MostUsedWords(text));
        }
    }
}
