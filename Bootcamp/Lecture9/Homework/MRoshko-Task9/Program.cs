using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

namespace MRoshko_Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();

            //Task2();

            Task3();

            //Task4();
        }

        public static void Task1()
        {
            var path = $@"C:\Users\martin.roshko\Desktop\ja-bootcamp-2021\Bootcamp\Lecture9\Homework\Tasks.txt";

            var lineCount = File.ReadAllLines(path).Length;

            Console.WriteLine(lineCount);
        }

        public static void Task2()
        {
            string dataStorage = default;
            string data = default;
            int lineCount = 0;
            int indexOfFile = 0;

            do
            {
                data = Console.ReadLine();

                if (data.Equals("LET ME OUT"))
                {
                    WriteIntoFile(dataStorage, indexOfFile);

                    MoveIntoFolder();
                }

                dataStorage += $"{data}\n";

                lineCount++;

                if (lineCount == 8)
                {
                    WriteIntoFile(dataStorage, indexOfFile);

                    indexOfFile++;
                    lineCount = 0;
                    dataStorage = default;
                }               
            }
            while (!data.Equals("LET ME OUT"));
        }

        public static void Task3()
        {
            var path = $@"{Directory.GetCurrentDirectory()}\Student.json";
            var group = new List<Student>();

            if (File.Exists(Path.GetFileName(path)))
            {                               
                string jsonReader = File.ReadAllText(path);

                group = JsonSerializer.Deserialize<List<Student>>(jsonReader);                
            }
            else
            {
                group = new List<Student>
            {
                new Student("Jack",23),
                 new Student("Martin",43),
                  new Student("Jhon",89),
                   new Student("Nick",51),
                    new Student("Max",9),
                     new Student("Anton",16),

            };
            }

            SemesterEmulation(group);

            string jsonWriter = JsonSerializer.Serialize(group);

            File.WriteAllText(path, jsonWriter);
        }

        public static void Task4()
        {
            var path = $@"{Directory.GetCurrentDirectory()}\CallLog.txt";

            Phone[] myPhones = new Phone[]
           {
                new IPhone13(7),
                new Nokia(8),
                new Nokia(16),
                new IPhone13(24),
                new Nokia(32),
                new Nokia(64),
                new IPhone13(23),
                new IPhone13(6),
                new IPhone13(24),
                new IPhone13(21),
                new Nokia(5)
           };

            var log = new Logger();

            for (int i = 0; i < 10; i++)
            {
                PhoneEmergencyTestHolder phones = new PhoneEmergencyTestHolder(myPhones);

                try
                {
                    TestEmergency(phones);
                }
                catch (BatteryIsDeadException ex)
                {
                    log.WriteLine(ex.ToString());

                    ex.Instance.Charge();
                }
            }
        }

        public static void WriteIntoFile(string data, int indexOfFile)
        {
            var directory = Directory.GetCurrentDirectory();

            string fileName = $@"{directory}\inputFromVIM{indexOfFile}.txt";

            try
            {
                File.WriteAllText(fileName,data);             
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void MoveIntoFolder()
        {
            var directory = Directory.GetCurrentDirectory();
            var targetPath = $@"{directory}{DateTime.Now.Day}{DateTime.Now.Month}{DateTime.Now.Year}";
            try
            {
                if (Directory.Exists(targetPath))
                {
                    Console.WriteLine("That folder already exist.");
                    throw new Exception("That folder already exist.");
                }

                DirectoryInfo di = Directory.CreateDirectory(targetPath);

                string[] files = Directory.GetFiles(directory, "*.txt");

                foreach (var f in files)
                {
                    if (Path.GetFileName(f).Contains("inputFromVIM"))
                    {
                        var fileName = Path.GetFileName(f);
                        var destFile = Path.Combine(targetPath, fileName);
                        File.Move(f, destFile, true);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void SemesterEmulation(List<Student> group)
        {

            for (int i = 0; i < 8; i++)
            {
                foreach (var student in group)
                {
                    if (!student.FavoriteNumber.Equals(student.LecturesAttended))
                    {
                        student.AttendLecture();
                    }
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
                catch (BatteryIsDeadException ex)
                {
                    if (phone is Nokia nokiaPhone)
                    {
                        nokiaPhone.PrayForBattery();

                        nokiaPhone.CallAmbulance();

                        continue;
                    }

                    Console.WriteLine($"Phone failed to call an ambulance: {phone.GetType()}");

                    throw;
                }
                finally
                {
                    phone.ChargeABit();
                }
            }

            Console.WriteLine();
        }
    }
}

