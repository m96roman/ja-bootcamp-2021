using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            File file = new File();

            Folder folder = new Folder();
            Folder newFolder = new Folder();

            newFolder.Add(new File());
            newFolder.Add(new File());

            folder.Add(newFolder);
            folder.Add(newFolder);
            user.GetRoot(folder);        
        }
    }
}
