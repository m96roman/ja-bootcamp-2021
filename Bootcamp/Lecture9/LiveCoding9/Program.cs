using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

namespace LiveCoding9
{
    class Program
    {
        static void Main(string[] args)
        {
            Serialization();
            SimulateSimpleStateProgram();
        }

        static void Files()
        {
            var directory = Directory.GetCurrentDirectory();
            Console.WriteLine(directory);

            var newDirectory = Directory.CreateDirectory("Subdirectory");

            Console.WriteLine($"{newDirectory.Name} vs {newDirectory.FullName}");
            Console.WriteLine($"{newDirectory.CreationTimeUtc}, Exists: {newDirectory.Exists}");

            var nonExistingDirectory = new DirectoryInfo("NonExistingDirectory");

            if (!nonExistingDirectory.Exists)
            {
                throw new DirectoryNotFoundException(nonExistingDirectory.FullName);
            }

            var bootcamp = new DirectoryInfo(@"C:\src\Bootcamp\Bootcamp");

            var filesInDirectory = bootcamp.GetFiles("*.cs", SearchOption.AllDirectories);

            foreach (var item in filesInDirectory)
            {
                Console.WriteLine($"{item.Name} - {item.CreationTimeUtc}");
            }

            using (var fileStream = File.Create($@"{newDirectory.FullName}\lecture9.txt"))
            {
                var message = "Let's have a look how to work with File Stream 2222";
                var messageBytes = Encoding.Default.GetBytes(message);

                fileStream.Write(messageBytes, 0, messageBytes.Length);
            }

            using var fileStreamForWriter = File.Create($@"{newDirectory.FullName}\lecture9.txt");
            using var streamWriter = new StreamWriter(fileStreamForWriter);

            streamWriter.WriteLine("Written from stream writer");
            streamWriter.Flush();

            File.AppendAllText($@"{newDirectory.FullName}\lecture9.txt", "from append");
            using (var streamWriter = File.CreateText($@"{newDirectory.FullName}\lecture9.txt"))
            {
                streamWriter.WriteLine("from create text");
            }

            using (var fileStream = File.Create($@"{newDirectory.FullName}\lecture9Zip.txt"))
            using (var zipStream = new GZipStream(fileStream, CompressionLevel.Fastest);
            using var zipStreamWriter = new StreamWriter(zipStream);
            zipStreamWriter.WriteLine("Hello from zip");

            var userInput = @"*askj*8\/";
            var invalidChars = Path.GetInvalidFileNameChars();
            var res = invalidChars.Where(c => userInput.Contains(c));

            var changedExtension = Path.ChangeExtension($@"{newDirectory.FullName}\lecture9Zip.txt", "zip");
            File.Move($@"{newDirectory.FullName}\lecture9Zip.txt", changedExtension);

            var textToWrite = "aklsdfjalsdfj alsdjf al";
            var fileInfoh = new FileInfo($@"{newDirectory.FullName}\lecture9.txt");
            fileInfoh.MoveTo($@"{newDirectory.Parent.FullName}\movedLecture9.txt");
            Console.ReadLine();
        }

        static void Serialization()
        {
            var user = new User
            {
                Nickname = "MLMLM",
                Age = 18,
                Password = "qwerty123"
            };

            var userJson = JsonSerializer.Serialize(user, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true,
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
            });
            File.WriteAllText("user.json", userJson);

            var xmlSerializer = new XmlSerializer(typeof(User));

            using (var xmlFile = File.Create("user.xml"))
            {
                xmlSerializer.Serialize(xmlFile, user);
            }

            using (var xmlFileToRead = File.OpenRead("user.xml"))
            {
                var userFromXml = xmlSerializer.Deserialize(xmlFileToRead);
            }

            var readJsonFromFile = File.ReadAllText("user.Json");
            var deserializedUser = JsonSerializer.Deserialize<User>(readJsonFromFile);

            Console.WriteLine(deserializedUser);

            var users = new List<User>
            {
                user,
                new User
                {
                    Nickname = "randomName321",
                    Age = 17,
                    Password = "qwerty321"
                }
            };

            File.WriteAllText("users.json", JsonSerializer.Serialize(users));
        }

        static void SimulateSimpleStateProgram()
        {
            var users = new List<User>();

            if (File.Exists("users.json"))
            {
                users.AddRange(JsonSerializer.Deserialize<List<User>>(File.ReadAllText("users.json")));
            }
            else
            {
                users.AddRange(new[]
                {
                    new User
                    {
                        Nickname = "greenTree8",
                        Age = 16,
                        Password = "qwerty123"
                    },
                    new User
                    {
                        Nickname = "randomName321",
                        Age = 17,
                        Password = "qwerty321"
                    }
                });
            }

            OneYearPassed(users);

            File.WriteAllText("users.json", JsonSerializer.Serialize(users));
        }

        static void OneYearPassed(IEnumerable<User> users)
        {
            foreach (var item in users)
            {
                item.Age += 1;
            }
        }
    }
}
