using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace KFedak_Task9
{
    public class Program
    {

        public static int indexOfFile = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("\nTask 1\n");

            Console.WriteLine($"Count of line: {CountLineInFile(WrriteFile())}");

            Console.WriteLine("\nTask 2\n");

            InfinitelyLongWriter();

            Console.WriteLine("\nTask 3\n");

            SimulateSemestr();
        }

        public static string WrriteFile()
        {
            var directory = Directory.GetCurrentDirectory();

            using (var fileStream = File.Create($@"{directory}\lecture9.txt"))
            {
                using var writer = new StreamWriter(fileStream);

                writer.WriteLine("Written from stream writer\nWritten from stream writer\nWritten from stream writer");

                return fileStream.Name;
            }
        }

        public static int CountLineInFile(string file)
        {
            var lineCounter = 0;
            using (var reader = new StreamReader(file))
            {
                while (reader.ReadLine() != null)
                {
                    lineCounter++;
                }
            }
            return lineCounter;
        }

        public static void InfinitelyLongWriter()
        {
            Console.WriteLine("Enter some text: ");

            string text = "";

            for (int i = 0; i < 8; i++)
            {
                string line = Console.ReadLine();
                if (line == "LET ME OUT")
                {
                    if (text.Length > 0)
                    {
                        using (var fileStream = File.Create($@"{Directory.GetCurrentDirectory()}\inputFromVIM{indexOfFile}.txt"))
                        {
                            using var writer = new StreamWriter(fileStream);
                            writer.WriteLine(text);
                            indexOfFile++;
                        }
                    }

                    List<String> myFiles = Directory
                   .GetFiles($@"{Directory.GetCurrentDirectory()}\", "inputFromVIM*.txt", SearchOption.TopDirectoryOnly)
                   .ToList();

                    var newDirectory = Directory.CreateDirectory($"Session_{DateTime.Now.ToString("hh-mm-ss")}");

                    foreach (var file in myFiles)
                    {
                        FileInfo mFile = new FileInfo(file);
                        if (new FileInfo($@"{newDirectory}\{mFile.Name}").Exists == false)
                        {
                            mFile.MoveTo($@"{newDirectory}\{mFile.Name}");
                        }
                    }
                    Environment.Exit(0);
                }
                text = text + line + "\n";
            }

            var directory = Directory.GetCurrentDirectory();

            using (var fileStream = File.Create($@"{directory}\inputFromVIM{indexOfFile}.txt"))
            {
                using var writer = new StreamWriter(fileStream);
                writer.WriteLine(text);
                indexOfFile++;
            }

            InfinitelyLongWriter();
        }

        static void SimulateSemestr()
        {
            var students = new List<Student>();

            if (File.Exists("snapshot.json"))
            {
                students.AddRange(JsonSerializer.Deserialize<List<Student>>(File.ReadAllText("snapshot.json")));
            }
            else
            {
                students.AddRange(new[]
                {
                    new Student
                    {
                        Name = "John",
                        LecturesAttended = 3
                    },
                    new Student
                    {
                        Name = "Mike",
                        LecturesAttended = 5
                    }
                });
            }

            SemesterPassed(students);

            File.WriteAllText("snapshot.json", JsonSerializer.Serialize(students));
        }

        static void SemesterPassed(IEnumerable<Student> students)
        {
            for (int i = 0; i < 8; i++)
            {
                foreach (var item in students)
                {
                    item.AttendedLecture();
                }
            }
        }
    }
}
