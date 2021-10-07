using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPlyskaLect9
{
    public class FileWorker
    {

        public int CountNumberLines(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException("Argument can not be null or an empty", nameof(path));
            }
            string [] files = File.ReadAllLines(path);

            return files.Length;
        }

        public static void ReadFromConsole()
        {
            List<string> container = new List<string>();

            Console.WriteLine("Please type some text. If you wanna quit just type quit ");

            string quit = string.Empty;

            while (quit != "quit")
            {
                container.Add(quit = Console.ReadLine());
            }

            CreateFile(container);

        }

        public static void CreateFile(List<string> data)
        {
            if (data is null || data.Count == 0)
            {
                throw new ArgumentNullException("Argument can not be null or an empty", nameof(data));
            }
        
            string folderName = $"Session_{DateTime.Now.DayOfWeek}";

            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }
 
            int counter = 1;
            int counter2 = 1;

            string fileName = $"inputFromVIM{counter}.txt";

            if (!File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            for (int i = 0; i < data.Count - 1; i++)
                {
                    File.AppendAllText(fileName, data[i]);
 
                    counter2++;

                    if (counter2 == 7)
                    {
                        counter++;
                        fileName = $"inputFromVIM{counter}.txt";

                        if (!File.Exists(fileName))
                        {
                            File.Create(fileName);
                        }
                        counter2 = 1;
                    }
                }

            var files = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.txt");

            foreach (var item in files)
            {
                File.Move(item, Directory.GetCurrentDirectory() + "\\" + folderName);
            }
            

        }
    }
}
