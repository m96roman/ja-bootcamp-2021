using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Shyptur_Task9_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task1();
            // Task2();
             Task3();
        }

        public static void Task1()
        {
            string path = @"C:\Users\Yevhen.shyptur\Documents\bootcamp\ja-bootcamp-2021\Bootcamp\Lecture9\Homework\Shyptur - Task9\Shyptur Task9 HW\bin\Debug\net5.0\Example txt files\Example.txt";
            var intCount = File.ReadLines(path).Count();
            Console.WriteLine(intCount);
        }

        public static void Task2()
        {
            int CounterLines = 0;
            int indexOfFile = 0;
            List<string> text = new List<string>();
            string STOP = "stop";
            string line = "";
            while (line != "stop")
            {
                line = Console.ReadLine();
                if (CounterLines == 7)
                {
                    using (StreamWriter streamWriter = new($"inputFromVim{ indexOfFile }.txt"))
                    {
                        foreach (var item in text)
                        {
                            streamWriter.WriteLine(item);
                        }
                        streamWriter.Flush();
                        indexOfFile += 1;
                        text.RemoveRange(0, text.Count);
                        CounterLines = 0;
                    }
                }
                else
                {
                    text.Add(line);
                    CounterLines += 1;
                }
            }
            if (text.Count != 0)
            {
                using (StreamWriter streamWriter = new($"inputFromVim{ indexOfFile }.txt"))
                {
                    foreach (var item in text)
                    {
                        streamWriter.WriteLine(item);
                    }
                    streamWriter.Flush();
                }
            }

            MoveIntoFolder();
        }

        public static void MoveIntoFolder()
        {
            var directory = Directory.GetCurrentDirectory();
            var targetPath = $@"{directory}\Session_{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}";
            try
            {
                if (Directory.Exists(targetPath))
                {
                    Console.WriteLine("That folder already exist.");
                    throw new Exception("That folder already exist.");
                }

                DirectoryInfo di = Directory.CreateDirectory(targetPath);
                string[] files = Directory.GetFiles(directory);

                Console.WriteLine(files.Length);

                foreach (var f in files)
                {
                    if (Path.GetFileName(f).Contains($"inputFromVim"))
                    {

                        var destFile = Path.Combine(targetPath, Path.GetFileName(f));
                        File.Move(f, destFile, true);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void Task3()
        {
            if (File.Exists("students.json"))
            {
                List<Student> students = new List<Student>();
                students.AddRange(JsonSerializer.Deserialize<List<Student>>(File.ReadAllText("students.json")));
                semesterEmulation(students);
            }
            else
            {
                List<Student> students = new List<Student>()
                {
                      new Student("Bill"),
                      new Student("Ron"),
                      new Student("Pol")
                };

                semesterEmulation(students);
            }
        }
        public static void semesterEmulation(List<Student> students)
        {
            for (int i = 0; i < 8; i++)
            {
                foreach (var item in students)
                {
                    item.AttendLecture(i);
                }
            }
            File.WriteAllText("students.json", JsonSerializer.Serialize(students));
        }
    }
}

