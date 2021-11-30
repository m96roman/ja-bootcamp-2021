using Editor.dll;
using Moq;
using NUnit.Framework;

namespace UnitTests.Moq
{
    public class EditorApiMoqTests
    {
        private readonly Mock<IGetFilesNames> _mockGetFiles = new Mock<IGetFilesNames>();

        EditorForMoqTests _editor;

        public EditorApiMoqTests()
        {
            this._editor = new EditorForMoqTests(_mockGetFiles.Object);
        }
      
       // [SetUp]
        public void Setup()
        {

        }

        [TestCase("testFoler", "test.txt")]
        public void GetFileNamesInStorage_Success(string folderName, string expected)
        {
            string[] test = { "test.txt", "hello.txt" };

            _mockGetFiles.Setup(s => s.GetFiles(folderName)).Returns(test);
          
            _editor.GetFileNamesInStorage();



           // Assert.AreEqual(expected, actual);
        }
    }
}