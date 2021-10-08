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

        public async Task Gettext(HttpClient client)
        {
            Text = await client.GetStringAsync(@"https://www.gutenberg.org/files/30155/30155-0.txt");
        }

        public async void SaveText()
        {
            await Task.Run(() => File.WriteAllText("relativs.txt", Text));
        }

        public async void FindLongestWord()
        {
            var result =  await Task.Run(()=> Text.Split(new char[] {' ', '\t', '\n' }, StringSplitOptions.TrimEntries).OrderByDescending(x => x.Length).First());

            Console.WriteLine($"the longest word is {result}");
        }

        public async void TopWordUsed()
        {
           List<string> container = new List<string>();

           var list = await Task.Run(() => Text.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries).GroupBy(x => x)
                                                 .OrderByDescending(g => g.Count())                   
                                                 .Take(8));

            Console.WriteLine("top 8(obviously) most common words used");

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Key}  ");
            }
        }

        public async void CountOneWord(string word)
        {
            var result = await Task.Run(() => Text.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries)
                                                  .Where(x => x == word).Count());

            Console.WriteLine($"Word Relativity is used {result}");
        }

    }
}
