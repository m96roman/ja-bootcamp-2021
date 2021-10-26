using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lecture10Task2
{
    public class HttpClientt
    {
        string path = "https://www.gutenberg.org/files/30155/30155-0.txt";

        public async Task<string> HttpClientReader()
        {
            var httpClinet = new HttpClient();
            string str = await httpClinet.GetStringAsync(path);

            Console.WriteLine($"HttpClientReader Thread is {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("------------------------\n\n");

            return str;
        }
    }
}
