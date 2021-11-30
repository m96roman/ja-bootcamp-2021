using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Editor.dll
{
    public class EditorForMoqTests : IEditorForMoqTests
    {

        private IGetFilesNames _getter;

        readonly static string directory = Directory.GetCurrentDirectory();
        readonly string targetFolder = @$"{directory}\Copied";
    
        public EditorForMoqTests(IGetFilesNames getter)
        {
            this._getter = getter;
        }

        public void CopyFile(string fileName, string text)
        {
            string filePath = @$"{targetFolder}\{fileName}";

            if (!Directory.Exists(targetFolder))
            {
                Directory.CreateDirectory(targetFolder);
            }

            File.WriteAllText(filePath, text);

        }

        public void CopyFileToStorage(string path)
        {
            if (!File.Exists(path))
            {
                throw new Exception("File can`t be copied, it does not exist or path is wrong.");
            }

            string fileName = path.Substring(path.LastIndexOf(("\\")) + 1);

            string destPath = @$"{targetFolder}\{fileName}";

            if (!Directory.Exists(targetFolder))
            {
                Directory.CreateDirectory(targetFolder);
            }

            if (File.Exists(destPath))
            {
                throw new Exception("File can`t be copied, it already exists.");
            }
            else
            {
                File.Copy(path, destPath, true);
            }
        }

        public string[] GetFileNamesInStorage()
        {
           return  _getter.GetFiles("folderName");
        }

        public int FindAndReplace(string fileName, string searchText, string replaceText)
        {
            var pathToFile = @$"{targetFolder}\{fileName}";

            if (!File.Exists(pathToFile))
            {
                throw new Exception("Can`t FindAndReplace, file with provided name does not exist.");
            }

            if (searchText == "" || replaceText == "")
            {
                throw new Exception("Can`t FindAndReplace, searchText or replaceText has no value.");
            }

            var text = File.ReadAllText(pathToFile);

            int matchCount = 0;

            var replaced = Regex.Replace(text, searchText, match =>
            {
                matchCount++;
                return replaceText;
            });

            File.WriteAllText(pathToFile, replaced);

            return matchCount;
        }

        public string[] SearchParagraphs(string fileName, string searchText)
        {
            var pathToFile = @$"{targetFolder}\{fileName}";

            if (!File.Exists(pathToFile))
            {
                throw new Exception("Can`t SearchParagraphs, file with provided name does not exist.");
            }

            var text = File.ReadAllText(pathToFile);

            var splitedParagrphs = text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            var searchedParagrphs = splitedParagrphs.Where(t => !t.Contains(searchText)).ToArray();

            return searchedParagrphs;
        }
    }

    public interface IGetFilesNames
    {
      public string[] GetFiles(string folderName);

    }

    public class GetFilesNames: IGetFilesNames
    {
        public string[] GetFiles(string folderName)
        {

           // if (!Directory.Exists(targetFolder))
           // {
            //    throw new Exception("Can`t GetFileNamesInStorage, directory does not exist yet.");
           // }
          
            string[] files = new DirectoryInfo(folderName).GetFiles().Select(f => f.Name).ToArray();
           
            if (files.Length == 0)
            {
                throw new Exception("Can`t GetFileNamesInStorage, current folder contains no files.");
            }

            return files;
        }
    }
}
