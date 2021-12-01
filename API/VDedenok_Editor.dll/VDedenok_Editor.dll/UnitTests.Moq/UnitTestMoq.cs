using Editor.dll;
using Moq;
using NUnit.Framework;

namespace UnitTests.Moq
{
    public class EditorApiMoqTests
    {
        

       
       // [SetUp]
        public void Setup()
        {

        }

        [TestCase("testFoler", "test.txt")]
        public void GetFileNamesInStorage_Success(string folderName, string expected)
        {
            Mock<IGetFilesNames> _mockGetFiles = new Mock<IGetFilesNames>();
          
            EditorForMoqTests _editor = new EditorForMoqTests(_mockGetFiles.Object);

            Mock<IEditorForMoqTests> _mockEditor = new Mock<IEditorForMoqTests>();

            _mockGetFiles.Setup(s => s.Folder()).Returns("test");
           
            string[] test = { "test.txt", "hello.txt" };
           
            _mockGetFiles.Setup(s=>s.GetFiles("test")).Returns(test);
           
            //act
            var res = _editor.GetFileNamesInStorage();
           
            var actual = res[0];

            Assert.AreEqual(expected, actual);
        }
    }
}