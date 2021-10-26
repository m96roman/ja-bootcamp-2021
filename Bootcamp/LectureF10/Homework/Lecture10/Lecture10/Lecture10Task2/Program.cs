using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Lecture10Task2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string path = @"C:\Users\nestor.pylat\ja-bootcamp-2021\Bootcamp\LectureF10\Homework\Lecture10\Lecture10\Lecture10Task2\Text.txt";

            TheMostUsedWord theMostUsedWord = new TheMostUsedWord();
            Saver saver = new Saver();
            HttpClientt httpClient = new HttpClientt();
            FindTheLongestWord findTheLongestWord = new FindTheLongestWord();
            RelativityUsing relativityUsing = new RelativityUsing();

            findTheLongestWord.FinderTheLongestWord(await File.ReadAllTextAsync(path));
            await httpClient.HttpClientReader();
            await saver.SaverTextAsync(path);
            theMostUsedWord.MostUsedWord(await File.ReadAllTextAsync(path));
            relativityUsing.RelativityUsingCounter();
        }
    }
}
