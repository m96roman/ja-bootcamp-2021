using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace Lecture10Task2
{
    class RelativityUsing
    {
        string path = @"C:\Users\nestor.pylat\ja-bootcamp-2021\Bootcamp\LectureF10\Homework\Lecture10\Lecture10\Lecture10Task2\Text.txt";

        HttpClientt httpClientt = new HttpClientt();
        public async void RelativityUsingCounter()
        {
            List<string> words = File.ReadAllText(path).Split(" ").ToList();
            var countOfRelativity = words.Count(word => word.Contains("relativity") || word.Contains("Relativity"));

            Console.WriteLine($"Count of relativity = {countOfRelativity}");
            Console.WriteLine($"RelativityUsingCounter thread: {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("------------------------\n\n");
        }
    }
}
