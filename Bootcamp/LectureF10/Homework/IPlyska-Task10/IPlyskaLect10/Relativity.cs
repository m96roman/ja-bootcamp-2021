using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;

namespace IPlyskaLect10
{
    public class Relativity
    {

        public string Text { get; private set; }

        char[] split = new char[] { '.', '?', '!', ' ', ';', ':', ',', '\t', '\n' };
    
        public async Task Gettext(HttpClient client)
        {
            Text = await client.GetStringAsync(@"https://www.gutenberg.org/files/30155/30155-0.txt");
        }

        public void SaveText()
        {
            File.WriteAllText("relativs.txt", Text);
        }

        public void FindLongestWord()
        {
            var result =   Text.Split(split, StringSplitOptions.TrimEntries).OrderByDescending(x => x.Length).First();

            Console.WriteLine($"the longest word is {result}");
        }

        public void TopWordUsed()
        {
           List<string> container = new List<string>();

           var list =  Text.Split(split, StringSplitOptions.RemoveEmptyEntries).GroupBy(x => x)
                                                 .OrderByDescending(g => g.Count())                   
                                                 .Take(8);

            Console.WriteLine("top 8(obviously) most common words used");

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Key}  ");
            }
        }

        public void CountOneWord(string word)
        {
            var result = Text.Split(split, StringSplitOptions.RemoveEmptyEntries)
                                                  .Where(x => x == word).Count();

            Console.WriteLine($"Word Relativity is used {result}");
        }

    }
}
