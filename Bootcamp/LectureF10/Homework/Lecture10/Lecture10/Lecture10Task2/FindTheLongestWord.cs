using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Lecture10Task2
{
    public class FindTheLongestWord
    {
        public void FinderTheLongestWord(string textInput)
        {
            List<string> text = textInput.Split(' ').Where(s => s.Length > 5).ToList();
            var longWordNumber = text.Max(s => s.Length);

            Console.WriteLine($"The Longest word has {longWordNumber} symbols");
            Console.WriteLine($"FinderTheLongestWord Thread is {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("------------------------\n\n");
        }
    }
}
