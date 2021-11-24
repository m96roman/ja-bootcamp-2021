using System;

namespace Composite
{
    static class Program
    {
        private static void Main(string[] args)
        {
            Component fileSystem = new Folder("File system");
            Component diskC = new Folder("Start path C:\\..");

            
            Component pictureComponent = new File("flower.jpg");
            Component textComponent = new File("text.txt");

            diskC.Add(pictureComponent);
            diskC.Add(textComponent);

            fileSystem.Add(diskC);

            fileSystem.PrintTree();

            Console.WriteLine("*****************************************");
            diskC.Remove(textComponent);
            
            Component myMusic = new Folder("My music");
            Component songOne = new File("sun.mp3");
            Component songTwo = new File("moon.mp3");

            myMusic.Add(songOne);
            myMusic.Add(songTwo);
            diskC.Add(myMusic);

            fileSystem.PrintTree();
        }
    }
}
