using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Editor.dll
{
    public  class FileManager: IDisposable
    {
        readonly static string directory = Directory.GetCurrentDirectory();
       
        readonly string targetFolder = @$"{directory}\Copied";
        readonly string sourceFolder = @$"{directory}\SourceFolder";

        public void CreateFile(string fileName)
        {
            Directory.CreateDirectory(targetFolder); 
           
            File.CreateText(@$"{targetFolder}\{fileName}");
        }

        public bool FileExist(string path)
        {
            if (File.Exists(path))
            {
                return true;
            }

            return false;
        }

        public void CopyFile(string fileName)
        {
            string destPath = @$"{targetFolder}\{fileName}";
           
            string source = @$"{sourceFolder}\{fileName}";
          
            Directory.CreateDirectory(targetFolder);

            File.Copy(source, destPath, true);
        }

        public void DeleteFolder()
        {
            if (Directory.Exists(targetFolder))
            {
                Directory.Delete(targetFolder, true);
            }
        }

        public void Dispose()
        {
            
        }
    }
}
