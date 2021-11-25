namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Composite */

            // create directories and files
            Component windows10 = new Directory("Windows 10");
                Component diskC = new Directory("//C");
                    Component backUp = new File("/BACKUP.MARKER");
                    Component programFiles = new Directory("/ProgramFiles");
                        Component visualStudio = new File("/VisualStudio2019.vs");
                        Component msTeams = new File("/MicrosoftTeams.ms");
                    Component src = new Directory("/src");
                        Component bootCamp = new Directory("/BootCamp");
                            Component lecture1 = new File("/Lecture1.txt");
                            Component lecture2 = new File("/Lecture2.txt");

            // add directories and files
            windows10.Add(diskC);
                diskC.Add(backUp);
                diskC.Add(programFiles);
                    programFiles.Add(visualStudio);
                    programFiles.Add(msTeams);
                diskC.Add(src);
                    src.Add(bootCamp);
                        bootCamp.Add(lecture1);
                        bootCamp.Add(lecture2);

            // visualize windows 10 file system
            windows10.GetInfo();
        }
    }
}
