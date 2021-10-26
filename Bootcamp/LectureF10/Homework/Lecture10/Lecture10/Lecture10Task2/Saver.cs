using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lecture10Task2
{
    public class Saver
    {
        HttpClientt httpClient = new HttpClientt();

        public async Task SaverTextAsync(string path)
        {
            File.WriteAllText(path, await httpClient.HttpClientReader());
            Console.WriteLine($"Saver thread is {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("------------------------\n\n");
        }
    }
}
