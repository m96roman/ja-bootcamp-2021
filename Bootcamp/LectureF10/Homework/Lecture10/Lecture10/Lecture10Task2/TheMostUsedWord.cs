using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace Lecture10Task2
{
    class TheMostUsedWord
    {
        public async void MostUsedWord(string text)
        {
            string regWords = text;
            var regMatches = Regex.Matches(regWords, "\\b(?<word>[^\\s]+?)\\b");
            var regCommonWords = regMatches.GroupBy(x => x.Groups["word"].Value).OrderByDescending(x => x.Count()).Take(8).Select(x => x.Key);

            Console.WriteLine($"\n\nThe most used words:");

            foreach (var x in regCommonWords)
            {
                Console.WriteLine($"Value: {x}");
            }

            Console.WriteLine("------------------------\n\n");
        }
    }
}
