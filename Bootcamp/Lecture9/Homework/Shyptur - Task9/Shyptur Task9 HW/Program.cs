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
            //Task1();

           // Task2();

             Task3();

            // Task4();
        }

        public static void Task1()
        {
            string path = $@"{Directory.GetCurrentDirectory()}\Example txt files\Example.txt";
            //string path = @"C:\Users\Yevhen.shyptur\Documents\bootcamp\ja-bootcamp-2021\Bootcamp\Lecture9\Homework\Shyptur - Task9\Shyptur Task9 HW\bin\Debug\net5.0\Example txt files\Example.txt";
            var intCount = File.ReadLines(path).Count();
            Console.WriteLine(intCount);
        }

        public static void Task2()
        {         
            int indexOfFile = 0;
            List<string> text = new List<string>();
            string line = "";

            while (line != "stop")
            {
                line = Console.ReadLine();
                if (text.Count == 7)
                {
                    text.Add(line);
                    File.WriteAllText($"inputFromVim{ indexOfFile }.txt", string.Join('\n', text));
                    indexOfFile += 1;
                    text.RemoveRange(0, text.Count);                  
                }
                else
                {
                    text.Add(line);                  
                }
            }
            if (text.Count != 0)
            {
                File.WriteAllText($"inputFromVim{ indexOfFile }.txt", string.Join('\n', text));
            }

            MoveIntoFolder();
        }

        public static void MoveIntoFolder()
        {
            var directory = Directory.GetCurrentDirectory();
            var targetPath = $@"{directory}\Session_{DateTime.Now}";
            try
            {
                if (Directory.Exists(targetPath))
                {
                    Console.WriteLine("That folder already exist.");
                    throw new Exception("That folder already exist.");
                }

                DirectoryInfo di = Directory.CreateDirectory(targetPath);
                string[] files = Directory.GetFiles(directory,"*.txt");

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

        public static void Task4()
        {
            Phone[] phones = new Phone[]
          {
             new Nokia(4),
                new Nokia(8),
                new Nokia(25),
                new IPhone13(4),
                new IPhone13(8),
                new IPhone13(25)
          };

            PhoneEmergencyTestHolder phoneEmergencyTestHolder = new PhoneEmergencyTestHolder(phones);

            for (int i = 0; i < 9; i++)
            {
                try
                {
                    TestEmergency(phoneEmergencyTestHolder);
                }
                catch (BatteryIsDeadException ex)
                {

                    Logger log = new Logger();
                    log.WriteLine(ex.ToString());
                    ex.PhoneInfo.Charge();
                }
            }
        }
        public static void TestEmergency(PhoneEmergencyTestHolder phoneEmergencyTestHolder)
        {
            foreach (Phone phone in phoneEmergencyTestHolder)
            {
                try
                {
                    phone.CallAmbulance();

                }
                catch (BatteryIsDeadException)
                {
                    if (phone is Nokia nokiaPhone)
                    {
                        nokiaPhone.PrayForBattery();
                        nokiaPhone.CallAmbulance();
                    }
                    else
                    {
                        throw;
                    }
                }
                finally
                {
                    phone.ChargeaBit();
                }
            }
        }
    }
}

