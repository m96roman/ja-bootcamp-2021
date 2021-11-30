using Editor.dll;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;

namespace UnitTestEditor.dll
{
    [TestFixture]
    public class Tests
    {
        [TearDown]
        public void DeleteTestFolder()
        {
            FileManager fileManager = new FileManager();

            fileManager.DeleteFolder();  
        }


        [Test]
        public void File_can_not_be_created_exception()
        {
            //arrange
            var testPath = $@"WrongPath";

            EdtitorApi editor = new EdtitorApi();

            //act
            var ex = Assert.Throws<Exception>(() => editor.CopyFileToStorage(testPath));

            //assert
            Assert.That(ex.Message, Is.EqualTo("File can`t be copied, it does not exist or path is wrong."));
        }

        [TestCase("Test.txt")]
        public void File_already_exists_exception(string fileName)
        {
            //arrange
            string directory = Directory.GetCurrentDirectory();
            string path = @$"{directory}\SourceFolder\{fileName}";
           
            EdtitorApi editor = new EdtitorApi();

            editor.CopyFileToStorage(path);

            //act
            var ex = Assert.Throws<Exception>(() => editor.CopyFileToStorage(path));

            //assert
            Assert.That(ex.Message, Is.EqualTo("File can`t be copied, it already exists."));
        }

        [TestCase("Test.txt")]
        public void File_is_copied_successfully(string fileName)
        {
            //arrange
            string directory = Directory.GetCurrentDirectory();

            var testPath = @$"{directory}\SourceFolder\{fileName}";

            EdtitorApi editor = new EdtitorApi();

            FileManager fileManager = new FileManager();

            //act
            editor.CopyFileToStorage(testPath);

            bool res = fileManager.FileExist(testPath);

            //assert
            Assert.IsTrue(res);

        }

        [TestCase("Text3.txt")]
        [TestCase("Text1.txt")]
        public void Get_file_names_success(string path1)
        {
            //arrange
            FileManager fileManager = new FileManager();

            fileManager.CreateFile(path1);

            string [] expected =  {path1};

            EdtitorApi editor = new EdtitorApi();

            //act
            string[] actual = editor.GetFileNamesInStorage();

            //assert
            Assert.AreEqual(expected, actual);

             GC.Collect();
        }

        [TestCase("Test.txt", "NIGHT", "night", 6)]
        [TestCase("Test.txt", "money", "MONEY", 3)]
        public void Find_and_replace_success(string fileName, string searchText, string replaceText, int expected)
        {
            //arrange
            EdtitorApi editor = new EdtitorApi();

            FileManager fileManager = new FileManager();

            fileManager.CopyFile(fileName);

            //act
            int actual = editor.FindAndReplace(fileName, searchText, replaceText);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Test.txt", "camp", 18)]
        [TestCase("Test.txt", "MacDonald", 21)]
        public void Search_paragraphs(string fileName, string searchText, int expected)
        {
            //arrange
            EdtitorApi editor = new EdtitorApi();

            FileManager fileManager = new FileManager();

            fileManager.CopyFile(fileName);

            //act 
            string[] res = editor.SearchParagraphs(fileName, searchText);

            int actual = res.Length;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}