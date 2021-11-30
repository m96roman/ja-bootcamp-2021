using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;

namespace Editor.dll.IntegrationTests
{
    public class Tests
    {
        [TearDown]
        public void Setup()
        {
            FileManager fileManager = new FileManager();
            fileManager.DeleteFolder();
        }

      //  [TestCase("First.txt", "Second.txt", "Third.txt")]
        public void Test_create_multiple_copies_returns_list_success(string name1, string name2, string name3)
        {
            //arrange
            string path = Directory.GetCurrentDirectory();
          
            CopyMiltipleFiles copyFiles = new CopyMiltipleFiles();
           
            FileManager fileManager = new FileManager();

            string[] expected = { name1, name2, name3 };

            List<String> pathes = new List<string>()
            {
              @$"{path}\SourceFolder\First.txt",
              @$"{path}\SourceFolder\Second.txt",
              @$"{path}\SourceFolder\Third.txt",
              "nonExistingPath"
            };

            //act
            string[] actual = copyFiles.CopyAndShowCreated(pathes);
           
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}