using System;
using System.Text;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory rootDir = new Directory(new IComposite[]
            {
                new File("123.txt"),
                new Directory(new IComposite[0],"777"),
                new Directory(new IComposite[]{
                    new Directory(new IComposite[]
                    {
                        new File("desired.png"),
                        new File("the-funny.jpeg")
                    },"important dir")
                },"7778"),
            }, "D:");

            File file = new File("thing.txt");

            rootDir.GetChildWithName("7778").GetChildWithName("important dir").AppendChildren(file);

            //Console.WriteLine(rootDir);
            Console.WriteLine(OpenInExplorer(rootDir, "7778\\important dir\\the-funny.jpeg"));
            Console.WriteLine(OpenInExplorer(rootDir, "7778\\important dir\\desired.png"));

            Console.WriteLine(GetPath(file));
        }

        private static string GetPath(IComposite composite)
        {
            StringBuilder stringBuilder = new StringBuilder();

            while (composite.Parent != null)
            {
                stringBuilder.Insert(0, "\\" + composite.Name);

                composite = composite.Parent;
            }

            stringBuilder.Insert(0, composite.Name);

            return stringBuilder.ToString();
        }

        private static IComposite OpenInExplorer(IComposite root, string v)
        {
            string[] parameters = v.Split("\\", StringSplitOptions.RemoveEmptyEntries);

            IComposite currentComposite = root;

            try
            {
                foreach (var item in parameters)
                {
                    if (!currentComposite.IsDirectory)
                    {
                        return null;
                    }

                    currentComposite = currentComposite.GetChildWithName(item);
                }

                return currentComposite;
            }
            catch (Exception)
            {
                Console.WriteLine("The address is invalid!");

                return null;
            }
        }
    }
}
