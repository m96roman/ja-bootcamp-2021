using NUnit.Framework;
using System.IO;
using System.Linq;

namespace QuadraticEquationMartin.IntegrationTest
{
    [TestFixture]
    public class InputDateIntegrationTest
    {
        private readonly InputDate Date = new InputDate();

        [TestCase("1", "2", "1", "< Root #1: -2 >", "FileResult.txt")]
        public void SolveAndSaveSolution_WithInicializedConstructor_ShouldWorkCorrectlyWith(string a, string b, string c, string result, string path)
        {
            string pathFile = $@"{Directory.GetCurrentDirectory()}\{path}";
            var date = new InputDate("2", "5", "1");

            date.SolveAndSaveSolution(a, b, c, path);

            Assert.IsTrue(File.ReadAllLines(pathFile)
                .Contains(result));

            File.Delete(pathFile);
        }

        [TestCase("1", "2", "1", "< Root #1: -2 >", "FileResult.txt")]
        [TestCase("7", "20", "1", "< Root #1: -2.494444673; Root #2: -137.505555327; >", "FileResult.txt")]
        public void SolveAndSaveSolution_EmptyConstructorResultDateNumbersPathFile_ShouldWorkCorrectlyWithNotFullInicializeConstructor(string a, string b, string c, string result, string path)
        {
            string pathFile = $@"{Directory.GetCurrentDirectory()}\{path}";           

            Date.SolveAndSaveSolution(a, b, c, path);

            Assert.IsTrue(File.ReadAllLines(pathFile)
                .Contains(result));

            File.Delete(pathFile);
        }

        [TestCase("< Root #1: 2; Root #2: 20; >", "Result.txt")]
        [TestCase("< Root #1: -3213; Root #2: 2343243.4332; >", "Result.txt")]
        [TestCase("< Root #1: 234; Root #2: 2389; >", "Result.txt")]
        [TestCase("< Root #1: 0; Root #2: 0; >", "Result.txt")]
        public void SaveResult_ResultFilePath_ShouldWriteCorrectResultIntoFile(string result, string path)
        {
            string pathFile = $@"{Directory.GetCurrentDirectory()}\{path}";

            Date.SaveResult(result, path);

            Assert.IsTrue(File.ReadAllLines(pathFile)
                .Contains(result));

            File.Delete(pathFile);
        }

        [TestCase("R#1: 5;R#2: 20;", "FileResult.txt")]
        [TestCase("R#1: 5;R#2: 20;", "MyFile.txt")]
        public void SaveResult_ResultAndFilePath_ShouldCreateFile(string value, string path)
        {
            string pathFile = $@"{Directory.GetCurrentDirectory()}\{path}";

            Date.SaveResult(value, path);

            Assert.IsTrue(File.Exists(pathFile));

            File.Delete(pathFile);
        }

        [TestCase("R#1: 5;R#2: 20;")]
        [TestCase("")]
        public void SaveResult_NoPath_ShouldCreateFileWithDefaultName(string value)
        {
            string pathFile = $@"{Directory.GetCurrentDirectory()}\FileResult.txt";

            Date.SaveResult(value);

            Assert.IsTrue(File.Exists(pathFile));

            File.Delete(pathFile);
        }
    }
}