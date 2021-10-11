using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Reader
{
    class Program
    {
        static void Main(string[] args)
        {
            Reader reader = new Reader();

            var text = reader.GetInputFromUser();

            Writer.WriteText(text);

        }
    }

    class Reader
    {
        public List<string> GetInputFromUser()
        {
            var stopWord = "LET ME OUT";
            var linesWithText = new List<string>();

            Console.WriteLine("Please enter text, press Enter to submit the text");

            while(true)
            {
                var input = Console.ReadLine();
                if(input == stopWord)
                {
                    break;
                };
                linesWithText.Add(input);
            }

            return linesWithText;
        }
    }

    static class Writer
    {
        public static void WriteText(List<string> text)
        {
            var formatedList = SplitListToParts(text, 8);
            var currentDir = Directory.GetCurrentDirectory();
            var fileList = new List<string>();
            var destFolder = $@"{currentDir}\Session_{DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss")}";

            for(var i = 0; i < formatedList.Count; i++)
            {
                var filePath = @$"{currentDir}\indexOfFile{i}.txt";
                File.AppendAllLines(filePath, formatedList[i]);
                fileList.Add($"indexOfFile{i}.txt");
            }

            Directory.CreateDirectory(destFolder);

            foreach (var item in fileList)
            {
                File.Move(item, @$"{destFolder}\\{item}");
            }
        }

        public static List<List<T>> SplitListToParts<T>(this List<T> source, int chunkSize)
        {
            return source
                .Select((x, i) => new { Index = i, Value = x })
                .GroupBy(x => x.Index / chunkSize)
                .Select(x => x.Select(v => v.Value).ToList())
                .ToList();
        }
    }
}
