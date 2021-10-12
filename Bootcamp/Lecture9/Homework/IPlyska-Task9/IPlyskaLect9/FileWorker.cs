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

            string folderName = $"Session_{DateTime.Now:dddd dd MMMM yyyy}";

            Console.WriteLine("Please type some text. If you wanna quit just type quit ");
            int counter = 1;
            string quit;

            do
            {
                quit = Console.ReadLine();

                if (quit != "quit")
                {
                    container.Add(quit);
                }

                if (container.Count == 8)
                {
                    CreateFile(container, counter, folderName);
                    counter++;
                    Move(folderName);
                    container.Clear();
                }
            }
            while(quit != "quit");

            CreateFile(container, counter, folderName);
            Move(folderName);

        }

        public static void CreateFile(List<string> data, int index, string folderName)
        {
            if (data is null || data.Count == 0)
            {
                throw new ArgumentNullException("Argument can not be null or an empty", nameof(data));
            }

            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }

            string fileName = $"inputFromVIM{index}.txt";

            File.WriteAllLines(fileName, data);
        }

        public static void Move(string folderName)
        {

            var files = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.txt");

            foreach (var item in files)
            {
                string name = Path.GetFileName(item);

                if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), folderName, name)))
                {
                    File.Delete(Path.Combine(Directory.GetCurrentDirectory(), folderName, name));
                }

                File.Move(item, Path.Combine(Directory.GetCurrentDirectory(), folderName, name));
            }
        }
    }
}
