using System;

namespace Task4_Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Component folder1 = new CompositeFolder("Folder1");
            Component folder = new CompositeFolder("Folder");
            Component document = new Document("Document1");
            Component document2 = new Document("Document2");
            Component document3= new Document("Document3");
            
            folder.Add(document);
            folder.Add(document3);
            folder.Add(document2);
            folder.Add(folder1);
            folder1.Add(document);
            folder1.Add(document3);


            folder.Display();
        }
    }
}
