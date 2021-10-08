using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ADovhanych_Task10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var httpClient = new HttpClient();
            var regExp = new Regex(@"[^\p{L}]*\p{Z}[^\p{L}]*");
            Task<string> file = httpClient.GetStringAsync("https://www.gutenberg.org/files/30155/30155-0.txt"); 
            List<string> words = new List<string>(file.Result.Split()); 

            string longest = words.OrderByDescending(s => s.Length).First();

            Console.WriteLine(longest);
        }
    }
}
